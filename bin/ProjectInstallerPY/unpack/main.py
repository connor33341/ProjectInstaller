import http.client
import argparse
import zipfile
import os
import uuid
import logging
import json

PROGRAMDIR = "C:\Program Files\ProjectInstaller\\"
CACHEDIR = f"{PROGRAMDIR}\cache\\"
LOGDIR = f"{PROGRAMDIR}\logs\\"
SESSIONID = uuid.uuid4()
FILENAME = os.path.basename(__file__)
Parser = argparse.ArgumentParser()
Parser.add_argument("--owner", type=str)
Parser.add_argument("--repo", type=str)
Parser.add_argument("--path", type=str)
Parser.add_argument("--buildfile", type=str)
Parser.add_argument("--branch", type=str)
Parser.add_argument("--force-url", type=str)
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
        self.Args = Parser.parse_args()
        self.ProjectConfig = f"{self.Args.path}\.projectinstaller\\"
        self.BuildFileReader = JsonReader(self.Logger,f"{self.ProjectConfig}{self.Args.buildfile}")
        self.BuildFile = self.BuildFileReader.Read()
        if self.ValidateArg("owner"):
            print("valid")
        else:
            print("invalid")
    def ValidateArg(self,Name):
        try:
            if self.Args[Name]:
                return True
            else:
                return False
        except Exception as Error:
            return False

if __name__ == "__main__":
    if os.path.isdir(LOGDIR):
        print("[INFO]: Logdir not valid")
        os.mkdir(LOGDIR)
    logging.basicConfig(filename=f"{LOGDIR}{SESSIONID}.log",level=logging.DEBUG,format='[%(asctime)s|%(levelname)s]: %(message)s')
    Logger = logging.getLogger(__name__)
    Logger.debug("Start")
    MainClass = Main(Logger)

