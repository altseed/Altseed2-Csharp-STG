Altseed2 Csharp STG

Altseed2のバージョン：2020/4/17/01:12現在

# ファイルコピーシステムの使い方

Scriptフォルダの中にシステムがあります。
以下の手順で準備を行います。

1. `/Copied`ディレクトリに，コピーしたいファイルを置きます。
1. `FileNames.txt`に，`/Copied`ディレクトリの中のコピーしたいファイルの名前(拡張子含めて，ディレクトリは書かずファイル名だけ)を書きます。  複数ファイルをコピーする場合は改行で区切る事が出来ます。
1. `DestDirectories.txt`に，コピー先のディレクトリ名を書きます。  ディレクトリは`Altseed2 Csharp STG`からのカレントディレクトリになります。  ディレクトリが存在しない場合は自動生成されます。
1. `FileCopySystem.exe`を起動すれば，自動的に全指定ディレクトリにコピーされます。

主にAltseed2.dll等の更新の際に役立つと思います。