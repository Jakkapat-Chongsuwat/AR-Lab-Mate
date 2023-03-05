#!/bin/bash

# Set the path to the directory where the artifact is located
ARTIFACT_DIR="$UNITY_PROJECT_PATH/Builds"

# Use the find command to search for the artifact with a .apk extension
ARTIFACT_PATH=$(find "$ARTIFACT_DIR" -name "*.apk" -type f)

# Output the path to the artifact
echo "$ARTIFACT_PATH"