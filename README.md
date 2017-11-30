# GUIDGenerator

Small console tool to create, convert or validate GUID's. The tool takes 3 main arguments, they are as follows:
1. Convert
2. Create
3. Verify
Each of these take additional arguments which are listed below

## GUID Conversion
Convert takes 2 addtional arguments, example usage:
##### To convert Oracle to .Net
```
convert net c40ee1a5-143e-40cf-9f54-f4a9acb0d6f8
```
##### To Convert .Net to Oracle
```
convert oracle c40ee1a5-143e-40cf-9f54-f4a9acb0d6f8
```
###### CMD Options are:
1. convert to: net or oracle
2. GUID to convert: This can be with or without the hyphen throughout the GUID.

## GUID Generator
Create takes 1 additional argument, example usage:
```
create 5
```
###### CMD Option is:
1. Number of GUID's to create

## GUID Validator
Verify takes 1 additional argument, example usage:
```
verify c40ee1a5-143e-40cf-9f54-f4a9acb0d6f8
```
###### CMD Option is:
1. GUID to verify
