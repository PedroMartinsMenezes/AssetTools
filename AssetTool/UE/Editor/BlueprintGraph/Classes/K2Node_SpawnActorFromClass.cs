namespace AssetTool
{
    [JsonAsset("K2Node_SpawnActorFromClass")]
    public class UK2Node_SpawnActorFromClass : UK2Node_ConstructObjectFromClass
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}