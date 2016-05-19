CREATE DEFINER=`root`@`localhost` PROCEDURE `upd_produit`(in cpu_prod int, in nom_prod varchar(40),in desc_prod varchar(250) , in pu_prod double, in cat_prod int )
BEGIN
Update bricachoc.produit
Set nomProduit = nom_prod,
descriptionProduit = desc_prod,
prixUnitaireProduit = pu_prod,
categorieProduit = cat_prod
where cpuProduit = cpu_prod;

END