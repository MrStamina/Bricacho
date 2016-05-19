CREATE DEFINER=`root`@`localhost` PROCEDURE `del_produit`(in cpu_prod int)
BEGIN
Delete from bricachoc.produit
where cpuProduit= cpu_prod;
END