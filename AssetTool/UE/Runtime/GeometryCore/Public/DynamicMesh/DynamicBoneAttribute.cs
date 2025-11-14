namespace AssetTool
{
    public class TDynamicBoneAttributeBase<ParentType, AttribValueType> : ITransferable<ParentType, AttribValueType>
    {
        public ITransferable Move(Transfer transfer, ParentType arg1, AttribValueType arg2)
        {
            throw new NotImplementedException();
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
