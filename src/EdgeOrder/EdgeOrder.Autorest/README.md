<!-- region Generated -->
# Az.EdgeOrder
This directory contains the PowerShell module for the EdgeOrder service.

---
## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.7.5 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.EdgeOrder`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
# readme.azure.noprofile.md is the common configuration file
  - $(this-folder)/../../readme.azure.noprofile.md
input-file:
# You need to specify your swagger files here.
  - $(repo)/specification/edgeorder/resource-manager/Microsoft.EdgeOrder/stable/2021-12-01/edgeorder.json
  
commit: 34018925632ef75ef5416e3add65324e0a12489f
# If the swagger has not been put in the repo, you may uncomment the following line and refer to it locally
# - (this-folder)/relative-path-to-your-swagger 

# For new RP, the version is 0.1.0
module-version: 0.1.0
# Normally, title is the service name
title: EdgeOrder
subject-prefix: $(service-name)
inlining-threshold: 50

directive:
  # Following is two common directive which are normally required in all the RPs
  # 1. Remove the unexpanded parameter set
  # 2. For New-* cmdlets, ViaIdentity is not required, so CreateViaIdentityExpanded is removed as well
  #^Update$|^UpdateViaIdentity$|^UpdateViaIdentityExpanded$|
  - where:
      variant: ^(Create|Update|Cance|Return)(?!.*?(Expanded|JsonFilePath|JsonString))
    remove: true
  - where:
      variant: ^CreateViaIdentity$|^CreateViaIdentityExpanded$|^GetViaIdentity$|^Validate.*$
    remove: true
  # Remove the set-* cmdlet
  - where:
      verb: Set
    remove: true

  - where:
      parameter-name: CustomerSubscriptionDetail 
    hide: true
  
  - where:
      parameter-name: IfMatch 
    hide: true
  
  - where:
      parameter-name: SkipToken 
    hide: true
  
  - where:
      verb: Get
      subject: Configuration
      variant: ^List$
    remove: true
  
  - where:
      verb: Get
      subject: ProductFamily
      variant: ^List$
    remove: true
  
  - where:
      verb: New
      parameter-name: ForwardAddressShippingAddress
    set:
      parameter-name: ForwardShippingAddress
  
  - where:
      verb: Stop
      subject: Order(.*)
    set:
      verb: Invoke
      subject: OrderItemCancellation
    
  - model-cmdlet:
      - model-name: OrderItemDetails
        cmdlet-name: New-AzEdgeOrderOrderItemDetailsObject
      - model-name: ShippingAddress
        cmdlet-name: New-AzEdgeOrderShippingAddressObject
      - model-name: ContactDetails
        cmdlet-name: New-AzEdgeOrderContactDetailsObject
      - model-name: Preferences
        cmdlet-name: New-AzEdgeOrderPreferencesObject
      - model-name: HierarchyInformation
        cmdlet-name: New-AzEdgeOrderHierarchyInformationObject
      - model-name: FilterableProperty
        cmdlet-name: New-AzEdgeOrderFilterablePropertyObject
```
``` yaml
directive:
  no-inline:  # the name of the model schema in the swagger file
    - OrderItemDetails
    - ShippingAddress
    - ContactDetails
    - Preferences
    - HierarchyInformation
    - CustomerSubscriptionDetails
    - FilterableProperty
    - SystemData
    
```
