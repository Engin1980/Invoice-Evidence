# Invoice Evidence

_Invoice Evidence_ is a simple project to organize and manage invoices represented as image files (png/jpg) on a hard drive. Simple usage scenarios:

1. User copies the invoice image file in the folder. Then asks the app to find this image, the user adds invoice data (shop, number, date, items, ...). Both information (data and image reference) are stored in a simple JSON datafile.
2. User can order all previously collected invoices and search the required ones by text.

Main features:

* Simple addition of new invoices in the application
* Text recognition from image supported during the invoice analysis
* Simple storage representation (one folder on a drive) allowing to have such folder on 'Google Drive' or 'Microsoft OneDrive'.
* Ordering and searching in the application 

## More technical background
### Storage

The storage is represented by a selected folder. In this folder, a JSON data file is saved and also the images with invoices are stored. To move the database to another location, simply copy the whole folder to another location. To add a new invoice, simply add its image file into the folder and let the app detect new images.

### Recognition

The application is able to recognize text from the invoice. The recognition is based on the Tesseract OCR project. Default supported languages are "Czech" and "English".

PDF files are supported via Ghostscript. This tool is used to convert the first page of PDF file into an image, which can be later processed via Tesseract OCR.

---
**Note**
Currently, only the first page of PDF file is processed. For other pages, custom conversion into image must be provided.

---

# Installation

---
**Note**
I have tested this only on 64bit OS and generally, only 64bit Windows OS is now supported. For 32bit support, source code improvements must be made.

---

For now, there is no specific installer. In releases, there are only compiled binaries for x64 platform. To install the app, follow the steps:

## 1. Main application
The main application is available at [Releases](https://github.com/Engin1980/Invoice-Evidence/releases) page. Download the specific release - ZIP file and unzip it into the target directory.

## 2. Tesseract OCR
The basic compiled Tesseract binaries are provided in release ZIP file. Check you have folder `tesseract-master.1153` in your application locatin.

To add the support for other than English language, you must download the language training files on your own. Find the appropriate Tesseract training file for the required language [here](https://github.com/tesseract-ocr/tessdata) and put it in the folder `tesseract-master.1153\tessdata`. Note the file language prefix (e.g., `eng` for English, `fra` for Francais, `cze` for Czech). You will need it to update the application settings later.

## 3. PDF Recongition (Optional))

To enable PDF file recognition support, [GhostScript](https://www.ghostscript.com/index.html) must be installed providing conversion of JPEG to PDF. It can be downloaded from [here](https://www.ghostscript.com/download/gsdnld.html). Note where the script is installed, you will need to know `gswin64c.exe` location to set up the application later.

# Initial setup

For the correct usage, you will need to set up the application settings correctly.

1. Start the application using `InvoiceEvidence.exe`.
2. If the application asks for the folder, just close and ignore the dialog. 
3. Open the settings window using the settings icon ![settings-icon](https://raw.githubusercontent.com/Engin1980/Invoice-Evidence/master/InvoiceEvidence/icons/settings.png).
4. Ensure you have set:
   * Supported file extension - `jpg;png`, change to `jpg;png;pdf` to enable PDF support;
   * Temp directory set to some valid temporal directory;
   * GhostScript location set to the correct GhostScript location, where `gsw64c.exe` is located 
   * Tesseract directory correctly set to the `tesseract-master.1153` folder.
   * Tesseract languages set to the required languages connected with plus sign, e.g. `eng+cze+fra`. Note that language abbreviation must match the training file abbreviation.

# Basic usage of the application



