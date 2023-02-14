$upFolder = [System.IO.Path]::Combine([System.IO.Directory]::GetCurrentDirectory(),"..");
$files = [System.IO.Directory]::GetFiles(".", "*.example");

foreach ($currentItemName in $files) {

    $fileName = [System.IO.Path]::GetFileNameWithoutExtension($currentItemName);

    $fileDestPath = [System.IO.Path]::Combine($upFolder, $fileName);

    if ([System.IO.File]::Exists($fileDestPath)) {
        [System.IO.File]::Delete($fileDestPath);
    }

    [System.IO.File]::Copy($currentItemName, [System.IO.Path]::Combine($upFolder,$fileName));
}