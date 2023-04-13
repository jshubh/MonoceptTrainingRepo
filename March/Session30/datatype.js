var x;
console.log(typeof (x));
x = 10;
console.log(typeof (x))
x = "helo";
console.log(typeof (x));
x = function ()
{
    console.log("inside fucntionj");
}
console.log(typeof (x));

x = {
    name: "manujant"

}
console.log(typeof (x))
console.log(this == window)