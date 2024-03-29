import http.client
import zipfile
import os
import uuid
import logging
import json

PROGRAMDIR = "C:\\Program Files\\Project Installer\\"
CACHEDIR = f"{PROGRAMDIR}\\cache\\"
LOGDIR = f"{PROGRAMDIR}\\logs\\"
SESSIONID = uuid.uuid4()
FILENAME = os.path.basename(__file__)

class JsonReader:
    def __init__(self,Logger,File):
        self.File = File
        self.Logger = Logger
    def Read(self):
        try:
            self.Logger.info(f"Attempting to read {self.File}")
            with open(self.File,'r') as File:
                return json.load(File)
        except Exception as Error:
            self.Logger.error("An error has occoured while reading json file: ",Error)
    def Write(self,NewJson):
        try:
            self.Logger.info(f"Attempting to write to {self.File}")
            with open(self.File,'w') as File:
                return json.dump(NewJson,File)
        except Exception as Error:
            self.Logger.error("An error has occoured while writing json file: ",Error)
class Main:
    def __init__(self,Logger):
        self.Logger = Logger

if __name__ == "__main__":
    logging.basicConfig(filename=f"{LOGDIR}{SESSIONID}.log",level=logging.DEBUG,format='[%(asctime)s|%(levelname)s]: %(message)s')
    Logger = logging.getLogger(__name__)
    Logger.debug("Start")

