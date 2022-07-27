﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class Insert_tb_City_New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Tb_City ([Description], StateId) VALUES
            ('Afonso Cláudio', 8),
            ('Água Doce do Norte', 8),
            ('Águia Branca', 8),
            ('Alegre', 8),
            ('Alfredo Chaves', 8),
            ('Alto Rio Novo', 8),
            ('Anchieta', 8),
            ('Apiacá', 8),
            ('Aracruz', 8),
            ('Atilio Vivacqua', 8),
            ('Baixo Guandu', 8),
            ('Barra de São Francisco', 8),
            ('Boa Esperança', 8),
            ('Bom Jesus do Norte', 8),
            ('Brejetuba', 8),
            ('Cachoeiro de Itapemirim', 8),
            ('Cariacica', 8),
            ('Castelo', 8),
            ('Colatina', 8),
            ('Conceição da Barra', 8),
            ('Conceição do Castelo', 8),
            ('Divino de São Lourenço', 8),
            ('Domingos Martins', 8),
            ('Dores do Rio Preto', 8),
            ('Ecoporanga', 8),
            ('Fundão', 8),
            ('Governador Lindenberg', 8),
            ('Guaçuí', 8),
            ('Guarapari', 8),
            ('Ibatiba', 8),
            ('Ibiraçu', 8),
            ('Ibitirama', 8),
            ('Iconha', 8),
            ('Irupi', 8),
            ('Itaguaçu', 8),
            ('Itapemirim', 8),
            ('Itarana', 8),
            ('Iúna', 8),
            ('Jaguaré', 8),
            ('Jerônimo Monteiro', 8),
            ('João Neiva', 8),
            ('Laranja da Terra', 8),
            ('Linhares', 8),
            ('Mantenópolis', 8),
            ('Marataízes', 8),
            ('Marechal Floriano', 8),
            ('Marilândia', 8),
            ('Mimoso do Sul', 8),
            ('Montanha', 8),
            ('Mucurici', 8),
            ('Muniz Freire', 8),
            ('Muqui', 8),
            ('Nova Venécia', 8),
            ('Pancas', 8),
            ('Pedro Canário', 8),
            ('Pinheiros', 8),
            ('Piúma', 8),
            ('Ponto Belo', 8),
            ('Presidente Kennedy', 8),
            ('Rio Bananal', 8),
            ('Rio Novo do Sul', 8),
            ('Santa Leopoldina', 8),
            ('Santa Maria de Jetibá', 8),
            ('Santa Teresa', 8),
            ('São Domingos do Norte', 8),
            ('São Gabriel da Palha', 8),
            ('São José do Calçado', 8),
            ('São Mateus', 8),
            ('São Roque do Canaã', 8),
            ('Serra', 8),
            ('Sooretama', 8),
            ('Vargem Alta', 8),
            ('Venda Nova do Imigrante', 8),
            ('Viana', 8),
            ('Vila Pavão', 8),
            ('Vila Valério', 8),
            ('Vila Velha', 8),
            ('Vitória', 8),
            ('Acrelândia', 1),
            ('Assis Brasil', 1),
            ('Brasiléia', 1),
            ('Bujari', 1),
            ('Capixaba', 1),
            ('Cruzeiro do Sul', 1),
            ('Epitaciolândia', 1),
            ('Feijó', 1),
            ('Jordão', 1),
            ('Mâncio Lima', 1),
            ('Manoel Urbano', 1),
            ('Marechal Thaumaturgo', 1),
            ('Plácido de Castro', 1),
            ('Porto Acre', 1),
            ('Porto Walter', 1),
            ('Rio Branco', 1),
            ('Rodrigues Alves', 1),
            ('Santa Rosa do Purus', 1),
            ('Sena Madureira', 1),
            ('Senador Guiomard', 1),
            ('Tarauacá', 1),
            ('Xapuri', 1),
            ('Água Branca', 2),
            ('Anadia', 2),
            ('Arapiraca', 2),
            ('Atalaia', 2),
            ('Barra de Santo Antônio', 2),
            ('Barra de São Miguel', 2),
            ('Batalha', 2),
            ('Belém', 2),
            ('Belo Monte', 2),
            ('Boca da Mata', 2),
            ('Branquinha', 2),
            ('Cacimbinhas', 2),
            ('Cajueiro', 2),
            ('Campestre', 2),
            ('Campo Alegre', 2),
            ('Campo Grande', 2),
            ('Canapi', 2),
            ('Capela', 2),
            ('Carneiros', 2),
            ('Chã Preta', 2),
            ('Coité do Nóia', 2),
            ('Colônia Leopoldina', 2),
            ('Coqueiro Seco', 2),
            ('Coruripe', 2),
            ('Craíbas', 2),
            ('Delmiro Gouveia', 2),
            ('Dois Riachos', 2),
            ('Estrela de Alagoas', 2),
            ('Feira Grande', 2),
            ('Feliz Deserto', 2),
            ('Flexeiras', 2),
            ('Girau do Ponciano', 2),
            ('Ibateguara', 2),
            ('Igaci', 2),
            ('Igreja Nova', 2),
            ('Inhapi', 2),
            ('Jacaré dos Homens', 2),
            ('Jacuípe', 2),
            ('Japaratinga', 2),
            ('Jaramataia', 2),
            ('Jequiá da Praia', 2),
            ('Joaquim Gomes', 2),
            ('Jundiá', 2),
            ('Junqueiro', 2),
            ('Lagoa da Canoa', 2),
            ('Limoeiro de Anadia', 2),
            ('Maceió', 2),
            ('Major Isidoro', 2),
            ('Mar Vermelho', 2),
            ('Maragogi', 2),
            ('Maravilha', 2),
            ('Marechal Deodoro', 2),
            ('Maribondo', 2),
            ('Mata Grande', 2),
            ('Matriz de Camaragibe', 2),
            ('Messias', 2),
            ('Minador do Negrão', 2),
            ('Monteirópolis', 2),
            ('Murici', 2),
            ('Novo Lino', 2),
            ('Olho d`Água das Flores', 2),
            ('Olho d`Água do Casado', 2),
            ('Olho d`Água Grande', 2),
            ('Olivença', 2),
            ('Ouro Branco', 2),
            ('Palestina', 2),
            ('Palmeira dos Índios', 2),
            ('Pão de Açúcar', 2),
            ('Pariconha', 2),
            ('Paripueira', 2),
            ('Passo de Camaragibe', 2),
            ('Paulo Jacinto', 2),
            ('Penedo', 2),
            ('Piaçabuçu', 2),
            ('Pilar', 2),
            ('Pindoba', 2),
            ('Piranhas', 2),
            ('Poço das Trincheiras', 2),
            ('Porto Calvo', 2),
            ('Porto de Pedras', 2),
            ('Porto Real do Colégio', 2),
            ('Quebrangulo', 2),
            ('Rio Largo', 2),
            ('Roteiro', 2),
            ('Santa Luzia do Norte', 2),
            ('Santana do Ipanema', 2),
            ('Santana do Mundaú', 2),
            ('São Brás', 2),
            ('São José da Laje', 2),
            ('São José da Tapera', 2),
            ('São Luís do Quitunde', 2),
            ('São Miguel dos Campos', 2),
            ('São Miguel dos Milagres', 2),
            ('São Sebastião', 2),
            ('Satuba', 2),
            ('Senador Rui Palmeira', 2),
            ('Tanque d`Arca', 2),
            ('Taquarana', 2),
            ('Teotônio Vilela', 2),
            ('Traipu', 2),
            ('União dos Palmares', 2),
            ('Viçosa', 2),
            ('Amapá', 4),
            ('Calçoene', 4),
            ('Cutias', 4),
            ('Ferreira Gomes', 4),
            ('Itaubal', 4),
            ('Laranjal do Jari', 4),
            ('Macapá', 4),
            ('Mazagão', 4),
            ('Oiapoque', 4),
            ('Pedra Branca do Amaparí', 4),
            ('Porto Grande', 4),
            ('Pracuúba', 4),
            ('Santana', 4),
            ('Serra do Navio', 4),
            ('Tartarugalzinho', 4),
            ('Vitória do Jari', 4),
            ('Alvarães', 3),
            ('Amaturá', 3),
            ('Anamã', 3),
            ('Anori', 3),
            ('Apuí', 3),
            ('Atalaia do Norte', 3),
            ('Autazes', 3),
            ('Barcelos', 3),
            ('Barreirinha', 3),
            ('Benjamin Constant', 3),
            ('Beruri', 3),
            ('Boa Vista do Ramos', 3),
            ('Boca do Acre', 3),
            ('Borba', 3),
            ('Caapiranga', 3),
            ('Canutama', 3),
            ('Carauari', 3),
            ('Careiro', 3),
            ('Careiro da Várzea', 3),
            ('Coari', 3),
            ('Codajás', 3),
            ('Eirunepé', 3),
            ('Envira', 3),
            ('Fonte Boa', 3),
            ('Guajará', 3),
            ('Humaitá', 3),
            ('Ipixuna', 3),
            ('Iranduba', 3),
            ('Itacoatiara', 3),
            ('Itamarati', 3),
            ('Itapiranga', 3),
            ('Japurá', 3),
            ('Juruá', 3),
            ('Jutaí', 3),
            ('Lábrea', 3),
            ('Manacapuru', 3),
            ('Manaquiri', 3),
            ('Manaus', 3),
            ('Manicoré', 3),
            ('Maraã', 3),
            ('Maués', 3),
            ('Nhamundá', 3),
            ('Nova Olinda do Norte', 3),
            ('Novo Airão', 3),
            ('Novo Aripuanã', 3),
            ('Parintins', 3),
            ('Pauini', 3),
            ('Presidente Figueiredo', 3),
            ('Rio Preto da Eva', 3),
            ('Santa Isabel do Rio Negro', 3),
            ('Santo Antônio do Içá', 3),
            ('São Gabriel da Cachoeira', 3),
            ('São Paulo de Olivença', 3),
            ('São Sebastião do Uatumã', 3),
            ('Silves', 3),
            ('Tabatinga', 3),
            ('Tapauá', 3),
            ('Tefé', 3),
            ('Tonantins', 3),
            ('Uarini', 3),
            ('Urucará', 3),
            ('Urucurituba', 3),
            ('Abaíra', 5),
            ('Abaré', 5),
            ('Acajutiba', 5),
            ('Adustina', 5),
            ('Água Fria', 5),
            ('Aiquara', 5),
            ('Alagoinhas', 5),
            ('Alcobaça', 5),
            ('Almadina', 5),
            ('Amargosa', 5),
            ('Amélia Rodrigues', 5),
            ('América Dourada', 5),
            ('Anagé', 5),
            ('Andaraí', 5),
            ('Andorinha', 5),
            ('Angical', 5),
            ('Anguera', 5),
            ('Antas', 5),
            ('Antônio Cardoso', 5),
            ('Antônio Gonçalves', 5),
            ('Aporá', 5),
            ('Apuarema', 5),
            ('Araças', 5),
            ('Aracatu', 5),
            ('Araci', 5),
            ('Aramari', 5),
            ('Arataca', 5),
            ('Aratuípe', 5),
            ('Aurelino Leal', 5),
            ('Baianópolis', 5),
            ('Baixa Grande', 5),
            ('Banzaê', 5),
            ('Barra', 5),
            ('Barra da Estiva', 5),
            ('Barra do Choça', 5),
            ('Barra do Mendes', 5),
            ('Barra do Rocha', 5),
            ('Barreiras', 5),
            ('Barro Alto', 5),
            ('Barro Preto (antigo Gov. Lomanto Jr.)', 5),
            ('Barrocas', 5),
            ('Belmonte', 5),
            ('Belo Campo', 5),
            ('Biritinga', 5),
            ('Boa Nova', 5),
            ('Boa Vista do Tupim', 5),
            ('Bom Jesus da Lapa', 5),
            ('Bom Jesus da Serra', 5),
            ('Boninal', 5),
            ('Bonito', 5),
            ('Boquira', 5),
            ('Botuporã', 5),
            ('Brejões', 5),
            ('Brejolândia', 5),
            ('Brotas de Macaúbas', 5),
            ('Brumado', 5),
            ('Buerarema', 5),
            ('Buritirama', 5),
            ('Caatiba', 5),
            ('Cabaceiras do Paraguaçu', 5),
            ('Cachoeira', 5),
            ('Caculé', 5),
            ('Caém', 5),
            ('Caetanos', 5),
            ('Caetité', 5),
            ('Cafarnaum', 5),
            ('Cairu', 5),
            ('Caldeirão Grande', 5),
            ('Camacan', 5),
            ('Camaçari', 5),
            ('Camamu', 5),
            ('Campo Alegre de Lourdes', 5),
            ('Campo Formoso', 5),
            ('Canápolis', 5),
            ('Canarana', 5),
            ('Canavieiras', 5),
            ('Candeal', 5),
            ('Candeias', 5),
            ('Candiba', 5),
            ('Cândido Sales', 5),
            ('Cansanção', 5),
            ('Canudos', 5),
            ('Capela do Alto Alegre', 5),
            ('Capim Grosso', 5),
            ('Caraíbas', 5),
            ('Caravelas', 5),
            ('Cardeal da Silva', 5),
            ('Carinhanha', 5),
            ('Casa Nova', 5),
            ('Castro Alves', 5),
            ('Catolândia', 5),
            ('Catu', 5),
            ('Caturama', 5),
            ('Central', 5),
            ('Chorrochó', 5),
            ('Cícero Dantas', 5),
            ('Cipó', 5),
            ('Coaraci', 5),
            ('Cocos', 5),
            ('Conceição da Feira', 5),
            ('Conceição do Almeida', 5),
            ('Conceição do Coité', 5),
            ('Conceição do Jacuípe', 5),
            ('Conde', 5),
            ('Condeúba', 5),
            ('Contendas do Sincorá', 5),
            ('Coração de Maria', 5),
            ('Cordeiros', 5),
            ('Coribe', 5),
            ('Coronel João Sá', 5),
            ('Correntina', 5),
            ('Cotegipe', 5),
            ('Cravolândia', 5),
            ('Crisópolis', 5),
            ('Cristópolis', 5),
            ('Cruz das Almas', 5),
            ('Curaçá', 5),
            ('Dário Meira', 5),
            ('Dias d`Ávila', 5),
            ('Dom Basílio', 5),
            ('Dom Macedo Costa', 5),
            ('Elísio Medrado', 5),
            ('Encruzilhada', 5),
            ('Entre Rios', 5),
            ('Érico Cardoso', 5),
            ('Esplanada', 5),
            ('Euclides da Cunha', 5),
            ('Eunápolis', 5),
            ('Fátima', 5),
            ('Feira da Mata', 5),
            ('Feira de Santana', 5),
            ('Filadélfia', 5),
            ('Firmino Alves', 5),
            ('Floresta Azul', 5),
            ('Formosa do Rio Preto', 5),
            ('Gandu', 5),
            ('Gavião', 5),
            ('Gentio do Ouro', 5),
            ('Glória', 5),
            ('Gongogi', 5),
            ('Governador Mangabeira', 5),
            ('Guajeru', 5),
            ('Guanambi', 5),
            ('Guaratinga', 5),
            ('Heliópolis', 5),
            ('Iaçu', 5),
            ('Ibiassucê', 5),
            ('Ibicaraí', 5),
            ('Ibicoara', 5),
            ('Ibicuí', 5),
            ('Ibipeba', 5),
            ('Ibipitanga', 5),
            ('Ibiquera', 5),
            ('Ibirapitanga', 5),
            ('Ibirapuã', 5),
            ('Ibirataia', 5),
            ('Ibitiara', 5),
            ('Ibititá', 5),
            ('Ibotirama', 5),
            ('Ichu', 5),
            ('Igaporã', 5),
            ('Igrapiúna', 5),
            ('Iguaí', 5),
            ('Ilhéus', 5),
            ('Inhambupe', 5),
            ('Ipecaetá', 5),
            ('Ipiaú', 5),
            ('Ipirá', 5),
            ('Ipupiara', 5),
            ('Irajuba', 5),
            ('Iramaia', 5),
            ('Iraquara', 5),
            ('Irará', 5),
            ('Irecê', 5),
            ('Itabela', 5),
            ('Itaberaba', 5),
            ('Itabuna', 5),
            ('Itacaré', 5),
            ('Itaeté', 5),
            ('Itagi', 5),
            ('Itagibá', 5),
            ('Itagimirim', 5),
            ('Itaguaçu da Bahia', 5),
            ('Itaju do Colônia', 5),
            ('Itajuípe', 5),
            ('Itamaraju', 5),
            ('Itamari', 5),
            ('Itambé', 5),
            ('Itanagra', 5),
            ('Itanhém', 5),
            ('Itaparica', 5),
            ('Itapé', 5),
            ('Itapebi', 5),
            ('Itapetinga', 5),
            ('Itapicuru', 5),
            ('Itapitanga', 5),
            ('Itaquara', 5),
            ('Itarantim', 5),
            ('Itatim', 5),
            ('Itiruçu', 5),
            ('Itiúba', 5),
            ('Itororó', 5),
            ('Ituaçu', 5),
            ('Ituberá', 5),
            ('Iuiú', 5),
            ('Jaborandi', 5),
            ('Jacaraci', 5),
            ('Jacobina', 5),
            ('Jaguaquara', 5),
            ('Jaguarari', 5),
            ('Jaguaripe', 5),
            ('Jandaíra', 5),
            ('Jequié', 5),
            ('Jeremoabo', 5),
            ('Jiquiriçá', 5),
            ('Jitaúna', 5),
            ('João Dourado', 5),
            ('Juazeiro', 5),
            ('Jucuruçu', 5),
            ('Jussara', 5),
            ('Jussari', 5),
            ('Jussiape', 5),
            ('Lafaiete Coutinho', 5),
            ('Lagoa Real', 5),
            ('Laje', 5),
            ('Lajedão', 5),
            ('Lajedinho', 5),
            ('Lajedo do Tabocal', 5),
            ('Lamarão', 5),
            ('Lapão', 5),
            ('Lauro de Freitas', 5),
            ('Lençóis', 5),
            ('Licínio de Almeida', 5),
            ('Livramento de Nossa Senhora', 5),
            ('Luís Eduardo Magalhães', 5),
            ('Macajuba', 5),
            ('Macarani', 5),
            ('Macaúbas', 5),
            ('Macururé', 5),
            ('Madre de Deus', 5),
            ('Maetinga', 5),
            ('Maiquinique', 5),
            ('Mairi', 5),
            ('Malhada', 5),
            ('Malhada de Pedras', 5),
            ('Manoel Vitorino', 5),
            ('Mansidão', 5),
            ('Maracás', 5),
            ('Maragogipe', 5),
            ('Maraú', 5),
            ('Marcionílio Souza', 5),
            ('Mascote', 5),
            ('Mata de São João', 5),
            ('Matina', 5),
            ('Medeiros Neto', 5),
            ('Miguel Calmon', 5),
            ('Milagres', 5),
            ('Mirangaba', 5),
            ('Mirante', 5),
            ('Monte Santo', 5),
            ('Morpará', 5),
            ('Morro do Chapéu', 5),
            ('Mortugaba', 5),
            ('Mucugê', 5),
            ('Mucuri', 5),
            ('Mulungu do Morro', 5),
            ('Mundo Novo', 5),
            ('Muniz Ferreira', 5),
            ('Muquém de São Francisco', 5),
            ('Muritiba', 5),
            ('Mutuípe', 5),
            ('Nazaré', 5),
            ('Nilo Peçanha', 5),
            ('Nordestina', 5),
            ('Nova Canaã', 5),
            ('Nova Fátima', 5),
            ('Nova Ibiá', 5),
            ('Nova Itarana', 5),
            ('Nova Redenção', 5),
            ('Nova Soure', 5),
            ('Nova Viçosa', 5),
            ('Novo Horizonte', 5),
            ('Novo Triunfo', 5),
            ('Olindina', 5),
            ('Oliveira dos Brejinhos', 5),
            ('Ouriçangas', 5),
            ('Ourolândia', 5),
            ('Palmas de Monte Alto', 5),
            ('Palmeiras', 5),
            ('Paramirim', 5),
            ('Paratinga', 5),
            ('Paripiranga', 5),
            ('Pau Brasil', 5),
            ('Paulo Afonso', 5),
            ('Pé de Serra', 5),
            ('Pedrão', 5),
            ('Pedro Alexandre', 5),
            ('Piatã', 5),
            ('Pilão Arcado', 5),
            ('Pindaí', 5),
            ('Pindobaçu', 5),
            ('Pintadas', 5),
            ('Piraí do Norte', 5),
            ('Piripá', 5),
            ('Piritiba', 5),
            ('Planaltino', 5),
            ('Planalto', 5),
            ('Poções', 5),
            ('Pojuca', 5),
            ('Ponto Novo', 5),
            ('Porto Seguro', 5),
            ('Potiraguá', 5),
            ('Prado', 5),
            ('Presidente Dutra', 5),
            ('Presidente Jânio Quadros', 5),
            ('Presidente Tancredo Neves', 5),
            ('Queimadas', 5),
            ('Quijingue', 5),
            ('Quixabeira', 5),
            ('Rafael Jambeiro', 5),
            ('Remanso', 5),
            ('Retirolândia', 5),
            ('Riachão das Neves', 5),
            ('Riachão do Jacuípe', 5),
            ('Riacho de Santana', 5),
            ('Ribeira do Amparo', 5),
            ('Ribeira do Pombal', 5),
            ('Ribeirão do Largo', 5),
            ('Rio de Contas', 5),
            ('Rio do Antônio', 5),
            ('Rio do Pires', 5),
            ('Rio Real', 5),
            ('Rodelas', 5),
            ('Ruy Barbosa', 5),
            ('Salinas da Margarida', 5),
            ('Salvador', 5),
            ('Santa Bárbara', 5),
            ('Santa Brígida', 5),
            ('Santa Cruz Cabrália', 5),
            ('Santa Cruz da Vitória', 5),
            ('Santa Inês', 5),
            ('Santa Luzia', 5),
            ('Santa Maria da Vitória', 5),
            ('Santa Rita de Cássia', 5),
            ('Santa Teresinha', 5),
            ('Santaluz', 5),
            ('Santana', 5),
            ('Santanópolis', 5),
            ('Santo Amaro', 5),
            ('Santo Antônio de Jesus', 5),
            ('Santo Estêvão', 5),
            ('São Desidério', 5),
            ('São Domingos', 5),
            ('São Felipe', 5),
            ('São Félix', 5),
            ('São Félix do Coribe', 5),
            ('São Francisco do Conde', 5),
            ('São Gabriel', 5),
            ('São Gonçalo dos Campos', 5),
            ('São José da Vitória', 5),
            ('São José do Jacuípe', 5),
            ('São Miguel das Matas', 5),
            ('São Sebastião do Passé', 5),
            ('Sapeaçu', 5),
            ('Sátiro Dias', 5),
            ('Saubara', 5),
            ('Saúde', 5),
            ('Seabra', 5),
            ('Sebastião Laranjeiras', 5),
            ('Senhor do Bonfim', 5),
            ('Sento Sé', 5),
            ('Serra do Ramalho', 5),
            ('Serra Dourada', 5),
            ('Serra Preta', 5),
            ('Serrinha', 5),
            ('Serrolândia', 5),
            ('Simões Filho', 5),
            ('Sítio do Mato', 5),
            ('Sítio do Quinto', 5),
            ('Sobradinho', 5),
            ('Souto Soares', 5),
            ('Tabocas do Brejo Velho', 5),
            ('Tanhaçu', 5),
            ('Tanque Novo', 5),
            ('Tanquinho', 5),
            ('Taperoá', 5),
            ('Tapiramutá', 5),
            ('Teixeira de Freitas', 5),
            ('Teodoro Sampaio', 5),
            ('Teofilândia', 5),
            ('Teolândia', 5),
            ('Terra Nova', 5),
            ('Tremedal', 5),
            ('Tucano', 5),
            ('Uauá', 5),
            ('Ubaíra', 5),
            ('Ubaitaba', 5),
            ('Ubatã', 5),
            ('Uibaí', 5),
            ('Umburanas', 5),
            ('Una', 5),
            ('Urandi', 5),
            ('Uruçuca', 5),
            ('Utinga', 5),
            ('Valença', 5),
            ('Valente', 5),
            ('Várzea da Roça', 5),
            ('Várzea do Poço', 5),
            ('Várzea Nova', 5),
            ('Varzedo', 5),
            ('Vera Cruz', 5),
            ('Vereda', 5),
            ('Vitória da Conquista', 5),
            ('Wagner', 5),
            ('Wanderley', 5),
            ('Wenceslau Guimarães', 5),
            ('Xique-Xique', 5),
            ('Abaiara', 6),
            ('Acarape', 6),
            ('Acaraú', 6),
            ('Acopiara', 6),
            ('Aiuaba', 6),
            ('Alcântaras', 6),
            ('Altaneira', 6),
            ('Alto Santo', 6),
            ('Amontada', 6),
            ('Antonina do Norte', 6),
            ('Apuiarés', 6),
            ('Aquiraz', 6),
            ('Aracati', 6),
            ('Aracoiaba', 6),
            ('Ararendá', 6),
            ('Araripe', 6),
            ('Aratuba', 6),
            ('Arneiroz', 6),
            ('Assaré', 6),
            ('Aurora', 6),
            ('Baixio', 6),
            ('Banabuiú', 6),
            ('Barbalha', 6),
            ('Barreira', 6),
            ('Barro', 6),
            ('Barroquinha', 6),
            ('Baturité', 6),
            ('Beberibe', 6),
            ('Bela Cruz', 6),
            ('Boa Viagem', 6),
            ('Brejo Santo', 6),
            ('Camocim', 6),
            ('Campos Sales', 6),
            ('Canindé', 6),
            ('Capistrano', 6),
            ('Caridade', 6),
            ('Cariré', 6),
            ('Caririaçu', 6),
            ('Cariús', 6),
            ('Carnaubal', 6),
            ('Cascavel', 6),
            ('Catarina', 6),
            ('Catunda', 6),
            ('Caucaia', 6),
            ('Cedro', 6),
            ('Chaval', 6),
            ('Choró', 6),
            ('Chorozinho', 6),
            ('Coreaú', 6),
            ('Crateús', 6),
            ('Crato', 6),
            ('Croatá', 6),
            ('Cruz', 6),
            ('Deputado Irapuan Pinheiro', 6),
            ('Ererê', 6),
            ('Eusébio', 6),
            ('Farias Brito', 6),
            ('Forquilha', 6),
            ('Fortaleza', 6),
            ('Fortim', 6),
            ('Frecheirinha', 6),
            ('General Sampaio', 6),
            ('Graça', 6),
            ('Granja', 6),
            ('Granjeiro', 6),
            ('Groaíras', 6),
            ('Guaiúba', 6),
            ('Guaraciaba do Norte', 6),
            ('Guaramiranga', 6),
            ('Hidrolândia', 6),
            ('Horizonte', 6),
            ('Ibaretama', 6),
            ('Ibiapina', 6),
            ('Ibicuitinga', 6),
            ('Icapuí', 6),
            ('Icó', 6),
            ('Iguatu', 6),
            ('Independência', 6),
            ('Ipaporanga', 6),
            ('Ipaumirim', 6),
            ('Ipu', 6),
            ('Ipueiras', 6),
            ('Iracema', 6),
            ('Irauçuba', 6),
            ('Itaiçaba', 6),
            ('Itaitinga', 6),
            ('Itapagé', 6),
            ('Itapipoca', 6),
            ('Itapiúna', 6),
            ('Itarema', 6),
            ('Itatira', 6),
            ('Jaguaretama', 6),
            ('Jaguaribara', 6),
            ('Jaguaribe', 6),
            ('Jaguaruana', 6),
            ('Jardim', 6),
            ('Jati', 6),
            ('Jijoca de Jericoacoara', 6),
            ('Juazeiro do Norte', 6),
            ('Jucás', 6),
            ('Lavras da Mangabeira', 6),
            ('Limoeiro do Norte', 6),
            ('Madalena', 6),
            ('Maracanaú', 6),
            ('Maranguape', 6),
            ('Marco', 6),
            ('Martinópole', 6),
            ('Massapê', 6),
            ('Mauriti', 6),
            ('Meruoca', 6),
            ('Milagres', 6),
            ('Milhã', 6),
            ('Miraíma', 6),
            ('Missão Velha', 6),
            ('Mombaça', 6),
            ('Monsenhor Tabosa', 6),
            ('Morada Nova', 6),
            ('Moraújo', 6),
            ('Morrinhos', 6),
            ('Mucambo', 6),
            ('Mulungu', 6),
            ('Nova Olinda', 6),
            ('Nova Russas', 6),
            ('Novo Oriente', 6),
            ('Ocara', 6),
            ('Orós', 6),
            ('Pacajus', 6),
            ('Pacatuba', 6),
            ('Pacoti', 6),
            ('Pacujá', 6),
            ('Palhano', 6),
            ('Palmácia', 6),
            ('Paracuru', 6),
            ('Paraipaba', 6),
            ('Parambu', 6),
            ('Paramoti', 6),
            ('Pedra Branca', 6),
            ('Penaforte', 6),
            ('Pentecoste', 6),
            ('Pereiro', 6),
            ('Pindoretama', 6),
            ('Piquet Carneiro', 6),
            ('Pires Ferreira', 6),
            ('Poranga', 6),
            ('Porteiras', 6),
            ('Potengi', 6),
            ('Potiretama', 6),
            ('Quiterianópolis', 6),
            ('Quixadá', 6),
            ('Quixelô', 6),
            ('Quixeramobim', 6),
            ('Quixeré', 6),
            ('Redenção', 6),
            ('Reriutaba', 6),
            ('Russas', 6),
            ('Saboeiro', 6),
            ('Salitre', 6),
            ('Santa Quitéria', 6),
            ('Santana do Acaraú', 6),
            ('Santana do Cariri', 6),
            ('São Benedito', 6),
            ('São Gonçalo do Amarante', 6),
            ('São João do Jaguaribe', 6),
            ('São Luís do Curu', 6),
            ('Senador Pompeu', 6),
            ('Senador Sá', 6),
            ('Sobral', 6),
            ('Solonópole', 6),
            ('Tabuleiro do Norte', 6),
            ('Tamboril', 6),
            ('Tarrafas', 6),
            ('Tauá', 6),
            ('Tejuçuoca', 6),
            ('Tianguá', 6),
            ('Trairi', 6),
            ('Tururu', 6),
            ('Ubajara', 6),
            ('Umari', 6),
            ('Umirim', 6),
            ('Uruburetama', 6),
            ('Uruoca', 6),
            ('Varjota', 6),
            ('Várzea Alegre', 6),
            ('Viçosa do Ceará', 6),
            ('Brasília', 7),
            ('Abadia de Goiás', 9),
            ('Abadiânia', 9),
            ('Acreúna', 9),
            ('Adelândia', 9),
            ('Água Fria de Goiás', 9),
            ('Água Limpa', 9),
            ('Águas Lindas de Goiás', 9),
            ('Alexânia', 9),
            ('Aloândia', 9),
            ('Alto Horizonte', 9),
            ('Alto Paraíso de Goiás', 9),
            ('Alvorada do Norte', 9),
            ('Amaralina', 9),
            ('Americano do Brasil', 9),
            ('Amorinópolis', 9),
            ('Anápolis', 9),
            ('Anhanguera', 9),
            ('Anicuns', 9),
            ('Aparecida de Goiânia', 9),
            ('Aparecida do Rio Doce', 9),
            ('Aporé', 9),
            ('Araçu', 9),
            ('Aragarças', 9),
            ('Aragoiânia', 9),
            ('Araguapaz', 9),
            ('Arenópolis', 9),
            ('Aruanã', 9),
            ('Aurilândia', 9),
            ('Avelinópolis', 9),
            ('Baliza', 9),
            ('Barro Alto', 9),
            ('Bela Vista de Goiás', 9),
            ('Bom Jardim de Goiás', 9),
            ('Bom Jesus de Goiás', 9),
            ('Bonfinópolis', 9),
            ('Bonópolis', 9),
            ('Brazabrantes', 9),
            ('Britânia', 9),
            ('Buriti Alegre', 9),
            ('Buriti de Goiás', 9),
            ('Buritinópolis', 9),
            ('Cabeceiras', 9),
            ('Cachoeira Alta', 9),
            ('Cachoeira de Goiás', 9),
            ('Cachoeira Dourada', 9),
            ('Caçu', 9),
            ('Caiapônia', 9),
            ('Caldas Novas', 9),
            ('Caldazinha', 9),
            ('Campestre de Goiás', 9),
            ('Campinaçu', 9),
            ('Campinorte', 9),
            ('Campo Alegre de Goiás', 9),
            ('Campo Limpo de Goiás', 9),
            ('Campos Belos', 9),
            ('Campos Verdes', 9),
            ('Carmo do Rio Verde', 9),
            ('Castelândia', 9),
            ('Catalão', 9),
            ('Caturaí', 9),
            ('Cavalcante', 9),
            ('Ceres', 9),
            ('Cezarina', 9),
            ('Chapadão do Céu', 9),
            ('Cidade Ocidental', 9),
            ('Cocalzinho de Goiás', 9),
            ('Colinas do Sul', 9),
            ('Córrego do Ouro', 9),
            ('Corumbá de Goiás', 9),
            ('Corumbaíba', 9),
            ('Cristalina', 9),
            ('Cristianópolis', 9),
            ('Crixás', 9),
            ('Cromínia', 9),
            ('Cumari', 9),
            ('Damianópolis', 9),
            ('Damolândia', 9),
            ('Davinópolis', 9),
            ('Diorama', 9),
            ('Divinópolis de Goiás', 9),
            ('Doverlândia', 9),
            ('Edealina', 9),
            ('Edéia', 9),
            ('Estrela do Norte', 9),
            ('Faina', 9),
            ('Fazenda Nova', 9),
            ('Firminópolis', 9),
            ('Flores de Goiás', 9),
            ('Formosa', 9),
            ('Formoso', 9),
            ('Gameleira de Goiás', 9),
            ('Goianápolis', 9),
            ('Goiandira', 9),
            ('Goianésia', 9),
            ('Goiânia', 9),
            ('Goianira', 9),
            ('Goiás', 9),
            ('Goiatuba', 9),
            ('Gouvelândia', 9),
            ('Guapó', 9),
            ('Guaraíta', 9),
            ('Guarani de Goiás', 9),
            ('Guarinos', 9),
            ('Heitoraí', 9),
            ('Hidrolândia', 9),
            ('Hidrolina', 9),
            ('Iaciara', 9),
            ('Inaciolândia', 9),
            ('Indiara', 9),
            ('Inhumas', 9),
            ('Ipameri', 9),
            ('Ipiranga de Goiás', 9),
            ('Iporá', 9),
            ('Israelândia', 9),
            ('Itaberaí', 9),
            ('Itaguari', 9),
            ('Itaguaru', 9);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
