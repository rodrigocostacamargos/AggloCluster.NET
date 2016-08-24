#Get any command line arguments passed in from C#
args <- commandArgs(trailingOnly = TRUE)
workingDirPath <- "C:/Users/rodrigo/Dropbox/FACCAMP/Qualificacao/ProjetoCSharp/AggloCluster3.3c/AggloCluster/RScript"
clusteringOutput <- "C:/Users/rodrigo/Dropbox/FACCAMP/Qualificacao/ProjetoCSharp/AggloCluster3.3c/AggloCluster/RScript/AggloClusterDistanceMatrix.csv"
cutHeight <- "0.25"

setwd(workingDirPath)								
							
#*************************************Clustering code starts below*********************************														
						
inputMatrixPath  <- "AggloClusterDistanceMatrix.csv"													

#read in the file and convert to a dist matrix						
distMatrix<-read.csv(inputMatrixPath,sep=",",header=T,row.names=1)						
#convert the input to a distance matrix of class "dist"						
distMatrix<-as.dist(as.matrix(distMatrix[,1:length(distMatrix)]))			

#cluster matrix data and create a dendrogram 						
jclust<-hclust(distMatrix,method="average")

#***************************Note******************************
# The cut height dictates how strict the algorithm is on putting images in the same cluster.
#
#   If the cut height (measure of dissimilarity) is set to .99 all images would be put in the 
#   same cluster.
#
#   If the cut height (measure of dissimilarity) is set to .1 almost all items would be placed in 
#   clusters of 1 (singletons).  							
#***************************End Note**************************

#Set your own cut height.
cuts<-cutree(jclust,h=cutHeight)

#Create the output file. 		
cutsOut <-data.frame(cbind(WebSite=jclust$labels,Cluster=cuts))						

#convert the cluster number to int and sort it
cutsOut$Cluster <- as.integer(cutsOut$Cluster)
cutsOut<-cutsOut[ order(cutsOut[,2]), ]	

# Write clustering output to a csv file.  Column names are removed since the data is read back into C#
write.table(cutsOut, file =clusteringOutput,row.names=FALSE, col.names=FALSE,sep=",",quote=FALSE)


#Extra Bonus Code!

# Making the cool dendrogram in the article. (you must run this in R, not from C#)
# remember to install the package: install.packages("ggplot2")
# remember to install the package: install.packages("ggdendro")

library(ggplot2)
library(ggdendro)
ggdendrogram(jclust, rotate = TRUE, size = 1, theme_dendro = FALSE)