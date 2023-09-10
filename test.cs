var x;
if (x < 0)
{
    x = 0;
}
else
{
    x = 1;
}

if (x > 0)
{
    x = 2;
}
else
{
    x = 3;
}

foreach (var i in new[] { 1, 2, 3 })
{
    x = i;
}
foreach (var i in new[] { 1, 2, 3 })
{
    x = i;
}
foreach (var i in new[] { 1, 2, 3 })
{
    x = i;
}
foreach (var i in new[] { 1, 2, 3 })
{
    x = i;
}
foreach (var i in new[] { 1, 2, 3 })
{
    foreach (var i in new[] { 1, 2, 3 })
    {
        foreach (var i in new[] { 1, 2, 3 })
        {
            foreach (var i in new[] { 1, 2, 3 })
            {
                x = i;
            }
        }
    }
}
