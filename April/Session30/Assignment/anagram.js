function checkAnagram()
{

    var word1 = document.getElementById("id1").value;
    var word2 = document.getElementById("id2").value;


    word1 = word1.toLowerCase().replace(/\s+/g, '');
    word2 = word2.toLowerCase().replace(/\s+/g, '');


    if (word1.length !== word2.length)
    {
        alert("Not anagrams!");
        return;
    }


    var sortedWord1 = word1.split('').sort().join('');
    var sortedWord2 = word2.split('').sort().join('');


    if (sortedWord1 === sortedWord2)
    {
        alert("The words are anagrams!");
    } else
    {
        alert("Not anagrams!");
    }


}
