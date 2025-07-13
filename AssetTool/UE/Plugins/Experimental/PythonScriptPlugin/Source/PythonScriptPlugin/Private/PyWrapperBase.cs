namespace AssetTool
{
    [JsonAsset("PythonObjectHandle")]
    public class UPythonObjectHandle : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}