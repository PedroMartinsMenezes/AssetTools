namespace AssetTool.Geometry
{
    using FDynamicMeshSculptLayerAttribute = TDynamicMeshVertexAttribute<TDouble, Const3>;

    public class FDynamicMeshSculptLayers : ITransferible
    {
        public int32 NumLayers;
        public int32 ActiveLayer;
        public double[] LayerWeights;
        public List<FDynamicMeshSculptLayerAttribute> Layers;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NumLayers);
            if (NumLayers > 0)
            {
                transfer.Move(ref ActiveLayer);
                transfer.Move(ref LayerWeights);
                transfer.Move(ref Layers, NumLayers);
            }
            return this;
        }
    }
}
