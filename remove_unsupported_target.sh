#!/bin/sh

# Version 0.1.0


# TODO grep -q to identify Frameworks
# TODO echo deleted item
# TODO add -v and -vv
# TODO add -i to ask user before deletion
# TODO check the case we are on root dir '/'

find . -iname "*.csproj" 2>/dev/null | while read -r
 do
	 echo "Found $REPLY"
	 sed -ri 's/(<TargetFrameworks>.*);net451(<\/TargetFrameworks>)/\1\2/' "$REPLY"
 done
