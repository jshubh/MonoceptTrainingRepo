var names = []
console.log(names)

names.push("shubh")
names.push("ekta")
names.push("ravi")
names.push("manjunath")
names.push("shubh")
console.log(names)['ekta', 'vikrant', 'anekant']
names.unshift("Monocept")
console.log(names)['Monocept', 'ekta', 'vikrant', 'anekant']

names.forEach((n) => console.log(n.toUpperCase());
var names_with_a = names.filter((name) => name.includes("a"));



var strNos = ["10", "20", "30", "40"]

strNos.map(no => console.log(parseInt(no) + parseInt(no)))


var sum = strNos.map(no => { return parseInt(no) }).reduce((a, b) => a + b)

console.log(sum)

var users = [{ id: 101, name: 'Anekanth', salary: 1000 }, { id: 102, name: 'Vikranth', salary: 2000 }]

users.forEach(n)=> console.log(u.id, u.name, u.salary))









