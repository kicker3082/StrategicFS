// Set up formatting for $ (USD) and % (Pct)
export const usd = new Intl.NumberFormat('en-US',
    {
        style: 'currency', currency: 'USD',
        minimumFractionDigits: 2
    });
export const pct = new Intl.NumberFormat('en-US',
    {
        style: 'percent',
        minimumFractionDigits: 2
    });

export var accountInfo = [];
export var url = "https://raw.githubusercontent.com/StrategicFS/Recruitment/master/data.json";
