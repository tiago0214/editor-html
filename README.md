# Editor HTML

A principal funcionalidade deste código é a manipulação de arquivos do tipo string, semelhante ao HTML.

## O que as classes implementadas fazem

Menu:

> - A classe **menu** é responsavel por exibir as opções principais do programa, como "Novo Arquivo", "Abrir" e "Sair".
> - O método **HandleMenuOption** é responsável por direcionar o programa para a funcionalidade correspondente com base na opção escolhida.

Editor:

> - A classe **Editor** é responsável pela edição de arquivos HTML.
> - O método **Start** permite ao usuário digitar o conteúdo do arquivo até pressionar a tecla "Escape".
> - Em seguida, o programa pergunta se o usuário deseja salvar o arquivo. Se sim, ele é salvo; caso contrário, o conteúdo é exibido usando a classe **Viewer**

Abrir:

> - A classe **Open** lida com a abertura de arquivos existentes.
> - O método **Abrir** pede ao usuário o caminho do arquivo e exibe o conteúdo usando a classe Viewer

Viewer:

> - A classe **Viewer** é responsável por exibir o conteúdo do arquivo HTML.
> - O método **Replace** substitui partes específicas do texto (marcadas com tags como \<blue>, \<red>, \<green>, \<yellow>) por cores correspondentes ao serem exibidas no console.

| Tags Disponiveis        |
| ----------------------- |
| **\<blue>\</blue>**     |
| **\<red>\</red>**       |
| **\<green>\</green>**   |
| **\<yellow>\</yellow>** |

> O texto dentro da tag, fica de acordo com o nome da cor que esta escrita em inglês.

No geral, este código representa um projeto prático que envolve vários conceitos fundamentais de programação em C# e fornece uma introdução ao desenvolvimento de aplicativos de console com funcionalidades de manipulação de arquivos e interação do usuário.
