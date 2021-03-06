<#
    .SYNOPSIS
        Removes the specified domain.

    .DESCRIPTION
        The Remove-Domain command removes the specified domain.


    .PARAMETER Name
        The name of the domain.

    .PARAMETER Force
        Indicates that the domain should be removed although it contains users in that domain.
    
    .INPUTS
        System.String
        Represents the name of a domain.        
    
    .OUTPUTS
        None.

    .NOTES
        Help Author: Adam Najmanowicz, Michael West

    .LINK
        https://github.com/SitecorePowerShell/Console/

    .EXAMPLE
        PS master:\> Remove-Domain -Name "domainName" 
#>
