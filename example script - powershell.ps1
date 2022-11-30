Get-Command -CommandType Cmdlet *date* > powershell-Date-Commands.txt

echo "This is a my profile batch file"
# Create a folder if it does not already exist
if (Get-Item -Path FolderA -ErrorAction Ignore) {
    echo "Folder already exists"
}
else
{

    echo "Creating folder"
    md FolderA
}
#
cd FolderA
# Create a file
echo "My Profile" > testfile.txt
# Append Content to the file
echo "New Line" >> testfile.txt
echo Another line without quotes >> testfile.txt
# Display file contents
echo "File after appending text"
cat testfile.txt
# Add content to the file - this overwrites the previous contents
echo "Mehdi's profile" > testfile.txt
# Display file contents
echo "File after adding text"
cat testfile.txt
# move back to parent directory
cd ..