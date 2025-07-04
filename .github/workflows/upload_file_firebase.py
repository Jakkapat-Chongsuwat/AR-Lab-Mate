import firebase_admin
from firebase_admin import credentials, storage
import os
import sys

# optional: Import UUID4 to create access token
from uuid import uuid4

# define githubTempPath as the path you store the key file
githubTempPath = '.github/workflows/'

# define the bucket name as a variable
bucket_name = 'metaschoolmeet-ff047'

# define the folder path in firebase storage
firebaseFolderPath = 'MetaSchoolLiteData/'

# google cloud's service account key file absolute path on github's machine directory
# note that the file name must be matched with the file name created from timheuer/base64-to-file@v1 action on the workflow
keyFilePath = githubTempPath + '/GOOGLE_SERVICE_KEY.json'

# apply the bucket domain to the credentials
cred = credentials.Certificate(keyFilePath)
firebase_admin.initialize_app(cred, {
    'storageBucket' : f'{bucket_name}.appspot.com'
})

# refer to the storage bucket
bucket = storage.bucket()

# get the upload file's path in repository's directory
# the file to upload in this scenario (a zip file) is in the same directory with the script
if len(sys.argv) > 1:
    fileName = sys.argv[1]
else:
    print("Error: File name not specified as a command-line argument.")
    exit()
dirname = os.path.dirname(os.path.realpath(__file__))
fileFullPath = dirname + '/' + fileName

# if the file name contains file path, the bucket will create folders corresponding to the path.
blob = bucket.blob(firebaseFolderPath + fileName)

# optional: Create new token, this one only used for downloading directly from firebase console page
accessToken = uuid4()

# optional: Create new dictionary with the metadata
metadata = { "firebaseStorageDownloadTokens": accessToken }

# optional: Set meta data for the blob wich contains the access token
blob.metadata = metadata

#upload to firebase storage
blob.upload_from_filename(fileFullPath)

# optional: make the file public
blob.make_public()

print("your file url ", blob.public_url)