# TO DO: split_Station_Data, save strings into json
from datetime import timedelta
from bs4 import BeautifulSoup as soup
from urllib.request import urlopen as uReq
import json
import html2text

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
attribute_list = []
data = {}

# Loop until all stations and their attributes are written
file = open('tmp.txt', 'r')
numStations = countStations(file)
file.close()


file = open('tmp.txt', 'r')
word_NOAA_Data = []
words_NOAA_Data = words(file)
for word in words_NOAA_Data:
	word_NOAA_Data.append(word)
file.close()

counter = 0
for i in range(len(word_NOAA_Data)):
	# Attribute Loop => 22 times for 22 words
	if counter == 21:
		attribute_list.append(word_NOAA_Data[i])
		data[str(attribute_list[0])] = {
			'Latitude': attribute_list[1],
			'Longitude': attribute_list[2],
			'Read Date': attribute_list[3] + '-' +
						attribute_list[4] + '-' +
						attribute_list[5] + ' ' +
						attribute_list[6] + ':' +
						attribute_list[7] + ' GST',
			'Wind Direction': attribute_list[8],
			'Wind Speed': attribute_list[9],
			'Wind Gust': attribute_list[10],
			'Wave Height': attribute_list[11],
			'Dominant Wave Period': attribute_list[12],
			'Atmospheric Pressure': attribute_list[15],
			'Air Temperature': attribute_list[17],
			'Water Termperature': attribute_list[18],
			'Visibility': attribute_list[20],
			'Tide': attribute_list[21] }

		with open("latest_obs.json", "a") as fp:
			json.dump(data, fp, sort_keys=False, indent=4, separators=(',', ': '))

		counter = 0
		attribute_list = []

	else:
		attribute_list.append(word_NOAA_Data[i])
		counter = counter + 1

