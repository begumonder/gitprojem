# gitprojem

##SÜRÜM KONTROL SİSTEMLERİ

Bir proje hazırlarken projemizin kodlarını yedeklememiz gerekiyo ancak yedekler çoğaldıkça karışıklığa neden oluyor ve anlamamız zorlaşıyor.Bu sorunu giderebilmek için projemizin yeddeklerini bizim yerimize alan programlar bulunmakta.Bu programlara sürüm kontrol sistemi denir.

##DAĞITIK VERSİYON KONTROL SİSTEMLERİ?

Dağıtık versiyon kontrol sistemlerinde birden fazla yerel depo ve birden fazla kullanıcı bulunur.Bir de uzak depo vardır. Bir projede birden fazla kişinin çalıştığını düşünelim.Dağıtık versiyon kontrol sistemlerinde projenin kopyası her kullanıcıda bulunur.Merkezi bir servera tüm kulanıcılar yaptığı değişiklikleri gönderebilir ve daha sonra kullanıcıların yaptığı tüm değişiklikler birleştirilebilir.Bunun dışında projeyi etkililcek bir çalışma yaptığınızı düşünüyorsanız ana dal olan master dalı bozmadan yan dallarda çalışma yapabilirsiniz.

##GİT NEDİR?

Git dağıtık versiyon kontrol sistemlerinin en yaygın olanıdır.Gitte dosyalarınız tek bir sunucu üzerinde değil birden çok sunucu üzerinde tutulur.

![resim](https://raw.githubusercontent.com/begumonder/gitprojem/master/resim/resim2.png)

##GİTİN İŞLEYİŞ BİÇİMİ?

Dosyalarınız üzerinde değişiklik yapılır.
Dosyalarınız hazırlık alanına eklenir.
Hazırılık alanındaki son halleri alınıp Git klasörüne kalıcı olarak depolanır.

![resim2](https://raw.githubusercontent.com/begumonder/gitprojem/master/resim/resim.jpg)

##GİTİN BAZI KOMUTLARI 
Add:projemizdeki değişiklikleri gite eklememize yarar.

`git add gitprojem.sln `

Commit:doyalarımız üzerinde yaptığımız değişiklikleri bildirdiğimiz komuttur. 

`git commit -m "ilk değişiklik" `

Remote:dosyalarımızı sunucuya göndermemizi sağlar.push ile remote edilir. 

`git remote add origin https://github.com/gitprojem/gitprojem`

git push:yaptığınız değişiklikleri uzak sunucuya göndermenizi sağlar.Bir projeyi push etmek istediğinizde size kulanıcı adı ve şifre
sorar eğer bilgileri doğru girerseniz ve projeye yazma izniniz var ise deişiklikleriniz push edilir.

`git push`

tüm değişiklikleri uzak sunucuya göndermenizi sağlar.

`git push origin master` 

master branchdeki değişiklikleri uzak sunucuya göndermenizi sağlar.

git pull:uzak sunucuda değişikliğe uğramış ya da yeni eklenmis dosya varsa bunları indirir ve yereldeki proje ile birleştirir.

`git pull https://github.com/begumonder/gitprojem`

git clone:Yerel ya da uzak sunucuda bulunan projenizi bulunduğunuz dizine kopyalamaya yarar. 

`git clone https://github.com/gitprojem/gitprojem `

git ceheckout:Projemiz üzerine önceden yapmış olduğumuz çalışmaları görmek istediğimizde kullanacağımız komuttur. 

`git checkout -b gitprojem`



##BRANCH(DALLANMA)
Yeni bir proje oluşturduğunuzda her zaman aktif bir branch üzerinde çalışırsınız.Aktif branchi bozmadan yeni bir çalışma yapmak istediğinizde kullanıcağınız yöntem ise aktif branch dışında yeni bir alt branch eklemek.Örneğin bir proje yaptığınızı varsayalım projenizde master branchi etkileyebileceğini düşündüğünüz bir çalışma yapmak istiyor olun.Bu durumda master branchin etkilenmemesi için yeni bir alt branch ekleyip onun üzerinde çalışma yapabilirsiniz.

projem adında yeni bir dl açıp oraya geçmek için

`git checkout -b projem`

tekrar master branche dönmek için 

`git checkout master`

oluşturduğunuz dalı silmek için

`git branch -d projem`

başkaları tarafından kullanılabilsin diye bir dalı uzak depoya göndermek için

`git push origin <projem>`

##MERGE (BİRLEŞTİRME)
Projenizde yeni bir branch oluşturdunuz ve bu branch üzerinde çalışma yaptınız.Bu branchdeki çalışmalarınızı master branche veya aktif olan branche eklemek istediğinizde kullanılan komut merge komutudur.Her zaman birleştirme işlemi gerçekleşmeyebilir bazı durumlarda çakışmalar olabilir.Git tarafından gösterilen dosyaları elle düzenleyerek çakışmaları birleştirmek size düşer.

`git merge projem`

değişikliklerden sonra dosyaları eklemek için

`git add <gitprojem>`


##GİTHUB NEDİR?
Git ile github aynı şey değildir.Git bir versiyon kontrol sistemidir.(Dağıtık versiyon kontrol sistemi de denir) Github ise  versiyon kontrol sistemleri için uzak bir depodur(repository).


##PULL REQUEST
Başka birisinin yaptığı projeyi alıp üzerinde çalışmalar yapıp proje sahibinden yaptığımız çalışmaları projeye çekmesini  isteğimiz işlemdir.Pull requst git ya da github ile gelen bir yaklaşım değildir.Pull request birden çok servisin kullanılmasıyla yapılmaktadır.(Git ve Github..)Örneğin başkasının projesinde bir değişiklik yapmak istiyor olalım.Bu durumda projeyi fork edip kendi bilgisayarımıza klonlarız.Klonlama işleminden sonra push işlemini yaparız.Projenin üzerinde değişikliklerimizi yapıp proje saahibine pull request isteginde bulunuruz eğer proje sahibi kabul ederse değişikliklerimizi projesine eklemiş olur.Peki ya biz klonlama işleminden sonra proje sahibi projede bir değişiklik yapsaydı ne yapmamız gerekirdi?İşte bu durumda bizde ana projedeki değişikliği almak için fetch ve upstream komutlarını kullanırız.Fetch uzak dedpodaki değişiklikleri çekerek kendi makinenize almamıza yarayan komuttur.upstream ise proje bağlantısına yeni isim vererek eklememize yarar.

<code>

git clone https://github.com/Y/ABC.git

 cd ABC

 1. değişiklik...

 git add README.adoc;

 git commit -m "1. Değişiklik"

 2. değişiklik...

 git add .travis.yml

 git commit -m "2. Değişiklik"

 git push origin

</code>

<code>

 git remote -v
 
origin  https://github.com/Y/ABC.git (fetch)

origin  https://github.com/Y/ABC.gitt (push)

upstream        https://github.com/X/ABC.git (fetch)

upstream        https://github.com/X/ABC.git (push)

</code>

Daha sonra master dalında olup olmadığımızı kontrol edip makinemizdeki master dalı ile upstreamdeki msater dalını birleştiriyoruz.Bu şekide hem uzak depoda hem de lokaldeki proje bilgilerinin son halini almış oluyoruz.

<code>
git checkout master # master dalına geçiliyor

git fetch upstream # uzaktaki projenin tüm verileri çekiliyor

git merge upstream/master # uzak depodaki master dalındaki değişiklikler birleştiriliyor.
</code>

##GİT-DEĞİŞİKLİKLERİ GERİ ALMA
Projeniz üzerinde çalışma yaparken eğer kaydı çok erken yapmışsanız, bazı dosyaları eklemeyi unutmuşsanız ya da kayıt mesajında hata yapmışsanız, gibi durumlarda kaydı değiştirmek zorunda kalabilirsiniz.

son kaydı geri alır

`git checkout -- gitprojem.sln`

Eğer tüm yerel değişiklik ve teslimlerinizi iptal etmek istiyorsanız

<code>
git fetch origin

git reset --hard origin/master

</code>

##GİT GEÇMİŞE GİTME
Yaptığınız çalışmalarada geriye dönmek istediğinizde kullanacağınız komutlardır.

git show:Yaptığınız değişiklikleri gösterir.

`git show`

gi show komutunun başka kullanım şekilleri de vardır.

`git show 217c9eb0077`

kullanacağınız ilk bir kaç kararkter yeterlidir.Bu komut ile görmek istediğiniz değişikliğe gidebilirsiniz.

`git show HEAD`

bu komut ile aktif dalda yaptığınz değişiklikleri görebilirsiniz.

##SÜRÜMLEMEK 
Yazılım sürümlerini oluşturmak için sürüm adı oluştururuz.
1.0.0 adıyla sürüm numarası oluşturmak için 

`git tag 1.0.0 1b2e1d63ff `

buradaki 1b2e1d63ff yayımlanacak yazılım sürümünüzün işlem numarasının ilk 10 karakteridir. 
İşlem kimlik numaralarını görmek için

`git log`

##PROJEDE KULLANDIĞIM PROGRAM HAKKINDA
Bu programın amacı 1'den 10'a kadar olan sayıları ekrana yazdırmak.Program için c# kullandım.Bu programı yazmamın amacı git işlemlerinden, git komutlarından öğrendiklerimi aktarmak.
