function longRunningOperation()
{
    let result = 0;
    for (let i = 0; i < 1000000000; i++)
    {
        result += i;
    }
    return result;
}

self.addEventListener('message', event =>
{
    if (event.data === 'start')
    {
        const result = longRunningOperation();
        self.postMessage(`Result: ${result}`);
    }
});
