import firebase_admin
from firebase_admin import credentials, storage
import os
import sys

# define the bucket name as a variable
bucket_name = 'metaschoolmeet-ff047'

# define the folder path in firebase storage
firebaseFolderPath = 'MetaSchoolLiteData/'

# google cloud's service account key file absolute path on github's machine directory
# note that the file name must be matched with the file name created from timheuer/base64-to-file@v1 action on the workflow
keyFilePath = '.github/workflows/GOOGLE_SERVICE_KEY.json'

# apply the bucket domain to the credentials
cred = credentials.Certificate(keyFilePath)
firebase_admin.initialize_app(cred, {
    'storageBucket' : f'{bucket_name}.appspot.com'
})

# refer to the storage bucket
bucket = storage.bucket()

# get the download file's path in repository's directory
if len(sys.argv) > 1:
    fileName = sys.argv[1]
else:
    print("Error: File name not specified as a command-line argument.")
    exit()
dirname = os.path.dirname(os.path.realpath(__file__))
fileFullPath = dirname + '/' + fileName

# locate the file in bucket
blob = bucket.blob(firebaseFolderPath + fileName)

# download from firebase storage
with open(fileFullPath, 'wb') as file:
    blob.download_to_file(file)

print("Downloaded file from Firebase Storage: ", fileFullPath)