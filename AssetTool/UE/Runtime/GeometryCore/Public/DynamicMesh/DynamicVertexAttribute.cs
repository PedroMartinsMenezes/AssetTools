namespace AssetTool.Geometry
{
    public class TDynamicMeshVertexAttribute<AttribValueType, AttribDimension, ParentType> : ITransferible where AttribValueType : ITransferible where AttribDimension : struct where ParentType : FDynamicMesh3
    {
        public virtual ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
