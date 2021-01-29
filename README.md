# Runita-8

### <strong> Endless Runner para Android </strong>

Este é o Runita-8, um endless runner em 2,5D no qual você é um corajoso soldado tentando escapar de um castelo em ruínas, após ter acordado o dragão que morava em seu interior. Depois de muito tempo, você percebe que o dragão te amaldiçoou e agora toda vez que você acha que vai morrer, você volta no tempo para o momento em que sua fuga começou. Sua última esperança é coletar as essências de magia púrpura das ruínas, então corre que o dragão está vindo!

<strong>Links:</strong> [Gamejolt](https://gamejolt.com/games/runita/573128) - [Itch.io](https://gb-dev.itch.io/runita-8) - [GitHub](https://github.com/GregBerb-DEV/Runita-8) - [Vídeo de apresentação](https://www.youtube.com/watch?v=WIF7puhvXpE&t=6s&ab_channel=GB-DEV)

---

### Menu - Behind the Scenes - Fase 4

<a href="https://gb-dev.itch.io/runita-8">
                                        <img height="400" src="https://i.imgur.com/0AB4kgc.jpg" title="source: imgur.com" />
                                        <img height="200" src="https://i.imgur.com/DxK1Zpl.jpg" title="source: imgur.com" />
                                        <img height="200" src="https://i.imgur.com/jZ84Ak9.jpg" title="source: imgur.com" />                                  
</a>

Para ver mais imagens ou jogar [clique aqui](https://gb-dev.itch.io/runita-8)

---

## Instalação

Para poder jogar Runita-8 no seu Android, você precisa do arquivo .apk do jogo. Ele pode ser baixado nos releases disponíveis aqui no GitHub, na [Gamejolt](https://gamejolt.com/games/runita/573128) ou no [Itch.io](https://gb-dev.itch.io/runita-8). Caso o seu celular não permita a instalação da primeira vez, é importante verificar se a opção de instalar aplicativos de fontes desconhecidas está ativada, e então tentar de novo.

---

### Movimentação

Há 2 entidades principais que se movimentam no Runita-8. Temos o jogador (representado por um cavaleiro) e o dragão. 

O jogador se move para a direita da tela sempre que possível para acompanhar o movimento da câmera, porém ele pode ser impedido por obstáculos, fazendo com que ele possa ficar para trás.

O dragão também sempre se movimenta para a direita, mas com diferenças sutis de velocidade, dependendo do quão perto ele se encontra do jogador. Normalmente, o dragão é levemente mais lento que o cavaleiro, fazendo com que ele apenas seja uma ameaça caso o jogador seja impedido de se mexer por tempo suficiente. Caso o jogador entre dentro da área de colisão do dragão, o jogo acaba da mesma forma que acabaria se o jogador caísse para fora da tela.

### Sonorização e Música

A música e efeitos sonoros foram obtidos no [Open Game Art](https://opengameart.org/) e foram implementados usando um script em C#. Há certos elementos que tornam a música um pouco mais dinâmica, como ela ficando mais lenta caso o jogador morra ou ela continuando a tocar entre fases.

### Fases

Apesar de ser um jogo de corrida infinita, o Runita-8 conta com 2 fases diferentes. Temos a fase principal, com montanhas rosadas no fundo e obstáculos gerados aleatoriamente, na qual o personagem está correndo do dragão e pode encontrar plataformas especiais com tochas. Ao pisar em uma das plataformas especiais ele é levado à fase bônus, com obstáculos em lugares fixos e o potencial de dar muitos pontos ao jogador se ele conseguir chegar ao final dela. O ciclo jogo é ir alternando entre essas duas fases sempre que possível para maximizar a quantidade de pontos obtidos.

---

## Créditos e Agradecimentos!

Este jogo foi feito por [Bernardo](https://github.com/Bemesko) e [Grégori](https://github.com/Greg-art) como um projeto para matéria de programação para jogos. Julgamos que não iríamos ter tempo o suficiente para produzirmos nossos próprios assets, então a maioria deles foi pego do [Open Game Art](https://opengameart.org/).

- [DragonBot: BOT FACTORY STORE](https://assetstore.unity.com/packages/3d/characters/creatures/dragon-bot-181926#description)
- [Dungeon Voxels: FullyBeta](https://assetstore.unity.com/packages/3d/environments/dungeons/voxel-dungeon-environment-set-1-57394)
- [Footman PBRHP Polyart: alexkim](https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/rpg-footman-pbr-hp-polyart-72070)
- [Parallax Background: @ansimuz](https://assetstore.unity.com/packages/2d/textures-materials/tiles/parallax-dusk-mountain-background-53403)
- [Sons do dragão: Michael Klier](https://opengameart.org/content/large-monster)
- [Sons do personagem: Michael Baradari](https://opengameart.org/content/11-male-human-paindeath-sounds)
- [Som do Item: CosmicD](https://opengameart.org/content/epic-amulet-item)
- [Música 1: Matthew Pablo](https://opengameart.org/content/dark-descent)

---

Desenvolvedores:
<strong>[Bernardo Pires Mesko](https://github.com/Bemesko)</strong>
e
<strong>[Grégori Sabel](https://github.com/Greg-art)</strong>
