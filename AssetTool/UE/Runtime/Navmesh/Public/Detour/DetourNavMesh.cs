namespace AssetTool
{
    public class dtMeshHeader
    {
        public ushort version;
        public ushort layer;
        public ushort polyCount;
        public ushort vertCount;
        public int x;
        public int y;
        public ushort maxLinkCount;
        public ushort detailMeshCount;
        public ushort detailVertCount;
        public ushort detailTriCount;
        public ushort bvNodeCount;
        public ushort offMeshConCount;
        public ushort offMeshBase;
        public ushort offMeshSegConCount;
        public ushort offMeshSegPolyBase;
        public ushort offMeshSegVertBase;
        public byte resolution;
        public double[] bmin = [0, 0, 0];
        public double[] bmax = [0, 0, 0];

        public ushort DummyClusterCount;
    }

    public class dtPoly
    {
        public uint firstLink;
        public ushort[] verts = [0, 0, 0, 0, 0, 0];
        public ushort[] neis = [0, 0, 0, 0, 0, 0];
        public ushort flags;
        public byte vertCount;
        public byte areaAndtype;
    }

    public class dtPolyDetail
    {
        public ushort vertBase;
        public ushort triBase;
        public byte vertCount;
        public byte triCount;
    }

    public class dtBVNode
    {
        public ushort[] bmin = [0, 0, 0];
        public ushort[] bmax = [0, 0, 0];
        public int i;
    }

    public class dtTriangleIndices
    {
        public byte index1;
        public byte index2;
        public byte index3;
        public byte index4;
    }

    public class dtOffMeshConnection
    {
        public double[] pos = [0, 0, 0, 0, 0, 0];
        public double rad;
        public ushort poly;
        public byte flags;
        public byte side;
        public uint id;
        public double height;
        public ulong userId;
    }

    public class dtOffMeshSegmentConnection
    {
        public double[] startA = [0, 0, 0];
        public double[] endA = [0, 0, 0];
        public double[] startB = [0, 0, 0];
        public double[] endB = [0, 0, 0];
        public double rad;
        public uint userId;
        public ushort firstPoly;
        public byte npolys;
        public byte flags;
    }

    public class dtCluster
    {
        public double[] center = [0, 0, 0];
        public uint firstLink;
        public uint numLinks;
    };
}