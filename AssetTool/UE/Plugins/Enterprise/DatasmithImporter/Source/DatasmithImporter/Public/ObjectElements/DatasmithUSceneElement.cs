namespace AssetTool
{
    [JsonAsset("DatasmithSceneElementBase")]
    public class UDatasmithSceneElementBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}