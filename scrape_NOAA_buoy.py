from bs4 import BeautifulSoup as soup
from usllib.request import urlopen as uReq

# Link to the plain text html
noaa_Data_url = "https://www.ndbc.noaa.gov/data/latest_obs/latest_obs.txt" 

# Link to the https search
single_page_url = "https://www.ndbc.noaa.gov/station_page.php?station=MDRM1"

# Open NOAA Latest Observations data page
uClient = uReq(noaa_Data_url)
page_raw_html = uClient.read()
	
# Close NOAA Latest Observation data page
uClient.close()

# Parse html
page_souped = soup(page_raw_html, "html.parser")

