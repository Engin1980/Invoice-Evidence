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

## Installation