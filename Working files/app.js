const fs = require('fs')

// fs.writeFileSync('newfile','hello world I was born from the nodejs server')

//appending a text to the file
fs.appendFile('newfile','\n hello varma i am your chimpanzee mind',(err) => {
    if (err) throw err ;
    console.log('The "data to append" was appended to file!');
});