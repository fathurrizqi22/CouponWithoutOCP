## Coupon without OCP
Sebuah program sederhana yaang melakukan simulasi perhitungan dengan coupon tanpa menerapkan prinsip `Open Closed Principle`.

### How does it works?
Membuat logika untuk beberapa pehitungan menggunakan `if else` pada sebuah method didalam class `Coupon.cs`
```csharp
 public double priceNett(double originPrice)
        {
            double net = 0;
            if (discNominal == 0 && disPercentage > 0)
            {
                net = (100 - disPercentage) * originPrice / 100;
            }
            else if(discNominal > 0 && disPercentage == 0)
            {
                net = originPrice - discNominal;
            }
            else if(discNominal > 0 && disPercentage > 0)
            {
                net = originPrice - discNominal;
            }
            return net;
        }
```
kemudian membuat object yang akan dihitung di main program `Program.cs`
```csharp
 Coupon coupon1 = new Coupon();
            coupon1.discNominal = 2000;
            Console.WriteLine(coupon1.priceNett(10000));

            Coupon coupon2 = new Coupon();
            coupon2.disPercentage = 15;
            Console.WriteLine(coupon2.priceNett(10000));

            Coupon coupon3 = new Coupon();
            coupon3.disPercentage = 90;
            coupon3.discNominal = 3000;
            Console.WriteLine(coupon3.priceNett(10000));

```