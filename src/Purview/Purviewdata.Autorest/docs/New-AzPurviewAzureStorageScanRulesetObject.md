---
external help file:
Module Name: Az.Purview
online version: https://learn.microsoft.com/powershell/module/az.Purview/new-AzPurviewAzureStorageScanRulesetObject
schema: 2.0.0
---

# New-AzPurviewAzureStorageScanRulesetObject

## SYNOPSIS
Create an in-memory object for AzureStorageScanRuleset.

## SYNTAX

```
New-AzPurviewAzureStorageScanRulesetObject -Kind <DataSourceType> [-Description <String>]
 [-ExcludedSystemClassification <String[]>] [-IncludedCustomClassificationRuleName <String[]>]
 [-ScanningRuleCustomFileExtension <ICustomFileExtension[]>]
 [-ScanningRuleFileExtension <FileExtensionsType[]>] [-Type <ScanRulesetType>] [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for AzureStorageScanRuleset.

## EXAMPLES

### Example 1: Create Azure Storage custom scanruleset object
```powershell
New-AzPurviewAzureStorageScanRulesetObject -Kind 'AzureStorage' -Description 'desc' -ExcludedSystemClassification @('MICROSOFT.FINANCIAL.CREDIT_CARD_NUMBER','MICROSOFT.SECURITY.COMMON_PASSWORDS') -IncludedCustomClassificationRuleName @('ClassificationRule2') -ScanningRuleFileExtension @("CSV","JSON","PSV","SSV","TSV","TXT","XML","PARQUET","AVRO","ORC","Documents","GZ","DOC","DOCM","DOCX","DOT","ODP","ODS","ODT","PDF","POT","PPS","PPSX","PPT","PPTM","PPTX","XLC","XLS","XLSB","XLSM","XLSX","XLT") -Type 'Custom'
```

```output
CreatedAt                            :
Description                          : desc
ExcludedSystemClassification         : {MICROSOFT.FINANCIAL.CREDIT_CARD_NUMBER, MICROSOFT.SECURITY.COMMON_PASSWORDS}
Id                                   :
IncludedCustomClassificationRuleName : {ClassificationRule2}
Kind                                 : AzureStorage
LastModifiedAt                       :
Name                                 :
ScanningRuleCustomFileExtension      :
ScanningRuleFileExtension            : {CSV, JSON, PSV, SSV…}
Status                               :
Type                                 : Custom
Version                              :
```

Create Azure Storage custom scanruleset object

## PARAMETERS

### -Description


```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExcludedSystemClassification


```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IncludedCustomClassificationRuleName


```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Kind


```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DataSourceType
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScanningRuleCustomFileExtension
To construct, see NOTES section for SCANNINGRULECUSTOMFILEEXTENSION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICustomFileExtension[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScanningRuleFileExtension


```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type


```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AzureStorageScanRuleset

## NOTES

## RELATED LINKS

