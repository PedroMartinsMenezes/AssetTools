namespace AssetTool
{
    [TransferibleStruct("VarArgument")]
    public class FVarArgument : ITransferible
    {
        [Location("FTG_Argument::StaticStruct()->SerializeItem(Ar, ((void*) &Argument), nullptr);")]
        public ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }
}
