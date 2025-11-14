namespace AssetTool
{
    [TransferableStruct("UniversalObjectLocatorFragment")]
    public class FUniversalObjectLocatorFragment : ITransferable
    {
        public FName FragmentTypeID;
        public UScriptStruct ScriptStruct;

        [Location("bool FUniversalObjectLocatorFragment::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
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
