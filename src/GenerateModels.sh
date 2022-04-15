#!/usr/bin/env bash
dotnet tool restore
dotnet tool run KontentModelGenerator -p "94db9a80-09dd-0076-6973-8c3b2f2e0ba4" -o "./Models" -n "StartBootstrap.Freelancer.Blazor.Models" -g true