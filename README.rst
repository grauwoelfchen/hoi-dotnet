Hoi .NET
==========

Hoi zäme ;)


Repository
----------

https://gitlab.com/grauwoelfchen/hoi-dotnet


Setup
-----

e.g. Gentoo Linux

.. code:: zsh

  : See https://github.com/gentoo/dotnet
  % sudo emerge -av layman
  % sudo layman -L dotnet
  % sudo layman -a dotnet

  # echo 'sys-devel/clang xml' >> /etc/portage/package.use/dotnet

  % sudo emerge -av dotnetcore-sdk-bin


.. code:: zsh

  : if your user in wheel group
  % sudo chown root:wheel -R /opt/dotnet_core
  % sudo mkdir /opt/dotnet_core/sdk/NuGetFallbackFolder
  % sudo chmod 775 /opt/dotnet_core/sdk/NuGetFallbackFolder


Usage
-----

Run
~~~~

.. code:: zsh

  % cd Hoi

  % dotnet restore
  % dotnet run
  Hoi Zäme!

Build
~~~~~~

.. code:: zsh

  % cd Hoi

  % dotnet restore
  % dotnet build

  % dotnet ./bin/Debug/netcoreapp2.0/Hoi.dll
  Hoi Zäme!


Test
-----

.. code:: zsh

  % cd Hoi.Tests

  % dotnet restore
  % dotnet test


License
-------

``The MIT License``

.. code:: text

  Copyright (c) 2018 Yasuhiro Asaka
