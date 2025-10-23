param(
  [string]$ProjectPath = 'Formulario MDI\Formulario MDI.csproj'
)

if (-not (Test-Path -LiteralPath $ProjectPath)) {
  Write-Error "Project file not found: $ProjectPath"
  exit 1
}

[xml]$xml = Get-Content -LiteralPath $ProjectPath
$nsUri = $xml.Project.NamespaceURI
$nsmgr = New-Object System.Xml.XmlNamespaceManager($xml.NameTable)
$nsmgr.AddNamespace('msb', $nsUri)

# Find an ItemGroup that already contains Reference children
$refGroup = $xml.Project.ItemGroup | Where-Object { $_.Reference } | Select-Object -First 1
if (-not $refGroup) {
  $refGroup = $xml.CreateElement('ItemGroup', $nsUri)
  $null = $xml.Project.AppendChild($refGroup)
}

# Check if the DataVisualization reference already exists
$exists = $false
if ($refGroup.Reference) {
  foreach ($r in $refGroup.Reference) {
    if ($r.Include -eq 'System.Windows.Forms.DataVisualization') { $exists = $true; break }
  }
}

if (-not $exists) {
  $ref = $xml.CreateElement('Reference', $nsUri)
  $null = $ref.SetAttribute('Include','System.Windows.Forms.DataVisualization')
  $null = $refGroup.AppendChild($ref)
  $xml.Save($ProjectPath)
  Write-Output 'Reference added'
} else {
  Write-Output 'Reference already exists'
}
