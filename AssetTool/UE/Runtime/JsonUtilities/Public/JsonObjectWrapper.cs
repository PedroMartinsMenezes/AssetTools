namespace AssetTool
{
    [JsonAsset("JsonUtilitiesDummyObject")]
    public class UJsonUtilitiesDummyObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}