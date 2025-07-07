namespace AssetTool
{
    [TransferibleStruct("UniversalObjectLocatorFragment")]
    public class FUniversalObjectLocatorFragment : ITransferible
    {
        public FName FragmentTypeID;
        public UScriptStruct ScriptStruct;

        [Location("bool FUniversalObjectLocatorFragment::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref FragmentTypeID);
            if (FragmentTypeID.IsFilled())
            {
                transfer.Move(ref ScriptStruct, x => x.SerializeItem(transfer));
            }
            return this;
        }
    }
}
