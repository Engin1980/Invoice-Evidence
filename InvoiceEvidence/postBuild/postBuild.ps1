Expand-Archive .\tesseract-master.1153.zip -DestinationPath .\bin\Debug\ -Force
Copy-Item .\tessdata\* -Destination .\bin\Debug\tesseract-master.1153\tessdata\ -Force -Recurse