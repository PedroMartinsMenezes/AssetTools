namespace AssetTool
{
    [JsonAsset("RecastNavMesh")]
    public class ARecastNavMesh : AActor
    {
        public uint32 NavMeshVersion;
        public uint32 RecastNavMeshSizeBytes;
        public byte[] Pad;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref NavMeshVersion);
            transfer.Move(ref RecastNavMeshSizeBytes);
            transfer.Move(ref Pad, (int)(RecastNavMeshSizeBytes - 4));

            return this;
        }
    }

    public class FDetourTileSizeInfo
    {
        public ushort VertCount;
        public ushort PolyCount;
        public ushort MaxLinkCount;
        public ushort DetailMeshCount;
        public ushort DetailVertCount;
        public ushort DetailTriCount;
        public ushort BvNodeCount;
        public ushort OffMeshConCount;
        public ushort OffMeshSegConCount;
        public ushort ClusterCount;
        public dtMeshHeader Header = new();
        public List<FVector3d> Vertices;
        public List<dtPoly> Polygons;
        public List<dtPolyDetail> PolyDetails;
        public List<FVector3d> DetailVerts;
        public List<dtTriangleIndices> DetailTris;
        public List<dtBVNode> BVTree;
        public List<dtOffMeshConnection> OffMeshConnections;
        public List<dtOffMeshSegmentConnection> OffMeshSegmentConnections;
        public List<dtCluster> Clusters;
        public uint16[] PolyClusters;

        [Location("void FPImplRecastNavMesh::SerializeRecastMeshTile(FArchive& Ar, int32 NavMeshVersion, unsigned char*& TileData, int32& TileDataSize)")]
        public void SerializeRecastMeshTile(Transfer transfer, int32 NavMeshVersion)
        {
            transfer.Move(ref VertCount);
            transfer.Move(ref PolyCount);
            transfer.Move(ref MaxLinkCount);

            transfer.Move(ref DetailMeshCount);
            transfer.Move(ref DetailVertCount);
            transfer.Move(ref DetailTriCount);

            transfer.Move(ref BvNodeCount);
            transfer.Move(ref OffMeshConCount);
            transfer.Move(ref OffMeshSegConCount);

            transfer.Move(ref ClusterCount);

            transfer.Move(ref Header.version);
            transfer.Move(ref Header.x);
            transfer.Move(ref Header.y);

            transfer.Move(ref Header.layer);
            transfer.Move(ref Header.polyCount);
            transfer.Move(ref Header.vertCount);

            transfer.Move(ref MaxLinkCount);
            transfer.Move(ref DetailMeshCount);
            transfer.Move(ref DetailVertCount);
            transfer.Move(ref DetailTriCount);

            transfer.Move(ref Header.bvNodeCount);
            transfer.Move(ref Header.offMeshConCount);
            transfer.Move(ref Header.offMeshBase);

            if (NavMeshVersion >= Consts.NAVMESHVER_TILE_RESOLUTIONS)
            {
                transfer.Move(ref Header.resolution);
            }

            transfer.Move(ref Header.bmin[0]);
            transfer.Move(ref Header.bmin[1]);
            transfer.Move(ref Header.bmin[2]);

            transfer.Move(ref Header.bmax[0]);
            transfer.Move(ref Header.bmax[1]);
            transfer.Move(ref Header.bmax[2]);

            transfer.Move(ref Header.DummyClusterCount);

            transfer.Move(ref Header.offMeshConCount);
            transfer.Move(ref Header.offMeshSegPolyBase);
            transfer.Move(ref Header.offMeshSegVertBase);

            MoveVertices(transfer);
            MovePolygons(transfer);
            MovePolyDetails(transfer);
            MoveDetailVerts(transfer);
            MoveDetailTris(transfer);
            MoveBVTree(transfer);
            MoveOffMeshConnections(transfer, NavMeshVersion);
            MoveOffMeshSegmentConnections(transfer);
            MoveClusters(transfer);
            MovePolyClusters(transfer);
        }

        [Location("for (int32 VertIdx=0; VertIdx < SizeInfo.VertCount; VertIdx++)")]
        private void MoveVertices(Transfer transfer)
        {
            transfer.Move(ref Vertices, VertCount);
        }

        [Location("for (int32 PolyIdx=0; PolyIdx < SizeInfo.PolyCount; ++PolyIdx)")]
        private void MovePolygons(Transfer transfer)
        {
            transfer.Resize(ref Polygons, PolyCount);

            foreach (var polygon in Polygons)
            {
                transfer.Move(ref polygon.firstLink);
                transfer.Move(ref polygon.verts, polygon.verts.Length);
                transfer.Move(ref polygon.neis, polygon.neis.Length);
                transfer.Move(ref polygon.flags);
                transfer.Move(ref polygon.vertCount);
                transfer.Move(ref polygon.areaAndtype);
            }
        }

        [Location("for (int32 MeshIdx=0; MeshIdx < SizeInfo.DetailMeshCount; ++MeshIdx)")]
        private void MovePolyDetails(Transfer transfer)
        {
            transfer.Resize(ref PolyDetails, DetailMeshCount);
            foreach (var polyDetail in PolyDetails)
            {
                transfer.Move(ref polyDetail.vertBase);
                transfer.Move(ref polyDetail.triBase);
                transfer.Move(ref polyDetail.vertCount);
                transfer.Move(ref polyDetail.triCount);
            }
        }

        [Location("for (int32 VertIdx=0; VertIdx < SizeInfo.DetailVertCount; ++VertIdx)")]
        private void MoveDetailVerts(Transfer transfer)
        {
            transfer.Move(ref DetailVerts, DetailVertCount);
        }

        [Location("for (int32 TriIdx=0; TriIdx < SizeInfo.DetailTriCount; ++TriIdx)")]
        private void MoveDetailTris(Transfer transfer)
        {
            transfer.Resize(ref DetailTris, DetailTriCount);
            foreach (var triangle in DetailTris)
            {
                transfer.Move(ref triangle.index1);
                transfer.Move(ref triangle.index2);
                transfer.Move(ref triangle.index3);
                transfer.Move(ref triangle.index4);
            }
        }

        [Location("for (int32 NodeIdx=0; NodeIdx < SizeInfo.BvNodeCount; ++NodeIdx)")]
        private void MoveBVTree(Transfer transfer)
        {
            transfer.Resize(ref BVTree, BvNodeCount);
            foreach (var node in BVTree)
            {
                transfer.Move(ref node.bmin, node.bmin.Length);
                transfer.Move(ref node.bmax, node.bmax.Length);
                transfer.Move(ref node.i);
            }
        }

        [Location("for (int32 ConnIdx=0; ConnIdx < SizeInfo.OffMeshConCount; ++ConnIdx)")]
        private void MoveOffMeshConnections(Transfer transfer, int32 NavMeshVersion)
        {
            transfer.Resize(ref OffMeshConnections, OffMeshConCount);
            foreach (var connection in OffMeshConnections)
            {
                transfer.Move(ref connection.pos, connection.pos.Length);
                transfer.Move(ref connection.rad);
                transfer.Move(ref connection.poly);
                transfer.Move(ref connection.flags);
                transfer.Move(ref connection.side);
                if (!transfer.Supports.NavigationLinkID32To64)
                {
                    transfer.Move(ref connection.id);
                }
                else
                {
                    transfer.Move(ref connection.userId);
                }
            }

            if (NavMeshVersion > Consts.NAVMESHVER_OFFMESH_HEIGHT_BUG)
            {
                OffMeshConnections.ForEach(x => transfer.Move(ref x.height));
            }
        }

        [Location("for (int32 SegIdx=0; SegIdx < SizeInfo.OffMeshSegConCount; ++SegIdx)")]
        private void MoveOffMeshSegmentConnections(Transfer transfer)
        {
            transfer.Resize(ref OffMeshSegmentConnections, OffMeshSegConCount);
            foreach (var offMeshSegmentConnection in OffMeshSegmentConnections)
            {
                transfer.Move(ref offMeshSegmentConnection.startA, offMeshSegmentConnection.startA.Length);
                transfer.Move(ref offMeshSegmentConnection.startB, offMeshSegmentConnection.startB.Length);
                transfer.Move(ref offMeshSegmentConnection.endA, offMeshSegmentConnection.endA.Length);
                transfer.Move(ref offMeshSegmentConnection.endB, offMeshSegmentConnection.endB.Length);
                transfer.Move(ref offMeshSegmentConnection.rad);
                transfer.Move(ref offMeshSegmentConnection.firstPoly);
                transfer.Move(ref offMeshSegmentConnection.npolys);
                transfer.Move(ref offMeshSegmentConnection.flags);
                transfer.Move(ref offMeshSegmentConnection.userId);
            }
        }

        [Location("for (int32 CIdx = 0; CIdx < SizeInfo.ClusterCount; ++CIdx)")]
        private void MoveClusters(Transfer transfer)
        {
            transfer.Resize(ref Clusters, ClusterCount);
            Clusters.ForEach(cluster => transfer.Move(ref cluster.center, cluster.center.Length));
        }

        [Location("for (int32 PolyClusterIdx = 0; PolyClusterIdx < polyClusterCount; ++PolyClusterIdx)")]
        private void MovePolyClusters(Transfer transfer)
        {
            transfer.Move(ref PolyClusters, DetailMeshCount);
        }
    }
}