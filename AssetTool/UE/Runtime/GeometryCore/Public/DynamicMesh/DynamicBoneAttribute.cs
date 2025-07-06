namespace AssetTool
{
    public class TDynamicBoneAttributeBase<ParentType, AttribValueType> : ITransferible<ParentType, AttribValueType>
    {
        public ITransferible Move(Transfer transfer, ParentType arg1, AttribValueType arg2)
        {
            throw new NotImplementedException();
        }

        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
