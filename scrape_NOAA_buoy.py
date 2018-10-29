# TO DO: split_Station_Data, save strings into json
from html2text import html2text
from datetime import timedelta
from bs4 import BeautifulSoup as soup
from urllib.request import urlopen as uReq
import json

class NOAA_Station(object):
	name = ""
	latitude = 0
	longitude = 0
	wind_Direction = ""
	wind_Speed = "" 
	wind_Gust = "" 
	wave_Height = "" 
	dominant_Wave_Period = "" 
	atmospheric_Pressure = "" 
	air_Temperature = "" 
	water_Temperature = "" 
	salinity = "" 
	visibility = "" 
	wind_Chill = "" 
	wind_Speed_At_20m = "" 
	wind_Speed_At_10m = "" 

	# The class initializer 
	def __init__(self, name, latitude, longitude, read_DateYY, read_DateMM,
		read_DateDD, read_Date_hh, read_Date_mm, read_Date_ss,
		wind_Direction, wind_Speed, wind_Gust, wave_Height,
		dominant_Wave_Period, atmospheric_Pressure, air_Temperature,
		water_Temperature, salinity, visibility, wind_Chill,
		wind_Speed_At_20m, wind_Speed_At_10m):
		self.name = name 
		self.latitude = latitude 
		self.longitude = longitude 
		self.read_DateYY = read_DateYY  
		self.read_DateMM = read_DateMM 
		self.read_DateDD = read_DateDD 
		self.read_Date_hh = read_Date_hh 
		self.read_Date_mm = read_Date_mm 
		self.read_Date_ss = read_Date_ss 
		self.wind_Direction = wind_Direction 
		self.wind_Speed = wind_Speed 
		self.wind_Gust = wind_Gust 
		self.wave_Height = wave_Height 
		self.dominant_Wave_Period = dominant_Wave_Period 
		self.atmospheric_Pressure = atmospheric_Pressure 
		self.air_Temperature = air_Temperature 
		self.water_Temperature = water_Temperature 
		self.salinity = salinity 
		self.visibility = visibility 
		self.wind_Chill = wind_Chill 
		self.wind_Speed_At_20m = wind_Speed_At_20m 
		self.wind_Speed_At_10m = wind_Speed_At_10m 

def make_NOAA_Station(name, lat, lon, YY, MM, DD, hh, mm, ss, wind_Dir,
					wind_SPD, wind_GST, wave_Height, dom_Wave_Period,
					atm_Pressure, air_Temp, water_Temp, salinity,
					visibility, wind_Chill, wind_SPD_20, wind_SPD_10):
	station = NOAA_Station()
	station.name = name
	return station	

def words(fileObj):
	counter = 0
	for line in fileObj:
		for word in line.split():
			yield word

def countStations(fileObj):
	counter = 0
	for line in fileObj:
		counter = counter + 1
	return counter

# Link to the plain text html
noaa_Data_url = "https://www.ndbc.noaa.gov/data/latest_obs/latest_obs.txt" 

# Link to the https search
single_page_url = "https://www.ndbc.noaa.gov/station_page.php?station=MDRM1"

# Open NOAA Latest Observations data page
uClient = uReq(noaa_Data_url)
page_raw_html = uClient.read()
	
# Close NOAA Latest Observation data page
uClient.close()

# Write the web data to local text file
file = open('tmp.txt', 'w')
file.write(page_raw_html.decode("utf-8"))
file.close()

# Read in 22 items from the text
file = open('tmp.txt', 'r')
lines_NOAA_Data = words(file)
file.close()

### Save the lines into local json files
counter = 0
attribute_list = []
data = {}
data['Stations'] = []

# Loop until all stations and their attributes are written
file = open('tmp.txt', 'r')
numStations = countStations(file)
print(numStations)
file.close()


file = open('tmp.txt', 'r')
lines_NOAA_Data = words(file)


for i in range(numStations):
	counter = 0
	# Attribute Loop => 22 times for 22 words
	for word in lines_NOAA_Data:
		attribute_list.append(word)
		if counter >= 22:
			break
		else:
			counter = counter + 1
	# Add all station names to 'Stations'
	data['Stations'].append({attribute_list[0]:
			[
				{
					'Latitude': attribute_list[1],
					'Longitude': attribute_list[2],
					'Read Date': attribute_list[3] +
								attribute_list[4] +
								attribute_list[5] +
								attribute_list[6] +
								attribute_list[7],
					'Wind Direction': attribute_list[8],
					'Wind Speed': attribute_list[9],
					'Wind Gust': attribute_list[10],
					'Wave Height': attribute_list[11],
					'Dominant Wave Period': attribute_list[12],
					'Atmospheric Pressure': attribute_list[15],
					'Air Temperature': attribute_list[17],
					'Water Termperature': attribute_list[18],
					'Visibility': attribute_list[20],
					'Tide': attribute_list[21]
				}
			]
		}
	)
	attribute_list = []
	
local_obs_json = open("latest_obs.json", "a", 1)
json.dump(data, local_obs_json, sort_keys=False,
			indent=4, separators=(',', ': '))

file.close()

