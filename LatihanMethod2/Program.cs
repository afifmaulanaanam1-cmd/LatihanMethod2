
int jumlahItem;

decimal hargaItem, diskon, totalBayar;

static decimal hitungDiskon(int jml_itemm)
{
    if (jml_itemm == 5) return 50000;
    else if (jml_itemm == 10) return 75000m;
    else return 0;
}

static decimal hitungTotal(int jml_item, decimal hrg_item, decimal diskon_item)
{
    return jml_item * hrg_item + diskon_item;
}

Console.WriteLine("Masukan jumlah item: ");
jumlahItem = int.Parse(Console.ReadLine());

Console.Write("Masukan harga per item: Rp ");
hargaItem = decimal.Parse(Console.ReadLine());

diskon = hitungDiskon(jumlahItem);

totalBayar = hitungTotal(jumlahItem, hargaItem, diskon);

Console.WriteLine($"Total yang harus dibayar adalah Rp {totalBayar}");

