CREATE DEFINER=`root`@`localhost` PROCEDURE `add_produit`(in cpu_Produit int, in nom_Produit varchar(40),
in desc_produit varchar(250), in prix_Unit double, in id_Cat_Prod int)
Begin
insert into bricachoc.produit(cpuProduit,nomProduit,descriptionProduit,prixUnitaireProduit,categorieProduit) 
values(cpu_Produit,nom_Produit,desc_produit,prix_Unit,id_Cat_Prod);



END