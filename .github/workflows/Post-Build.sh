#!/bin/bash

#This is a sample that will simply output the path to the build artifact

echo "START"

PLAYER_PATH=$UNITY_PLAYER_PATH

#IF we are using a Windows Builder and using the path to pass it to a native Windows application we need to properly convert the cygwin player path to windows format

if [[ "$BUILDER_OS" == "WINDOWS" ]]; then
PLAYER_PATH=$(cygpath -wa "$UNITY_PLAYER_PATH")
fi

echo "$PLAYER_PATH"