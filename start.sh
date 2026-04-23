#!/bin/bash
cd /home/ec2-user/sampleapp
dotnet sampleapp.dll > app.log 2>&1 &
