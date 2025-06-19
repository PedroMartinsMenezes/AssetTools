namespace AssetTool
{
    [JsonAsset("DatasmithSceneComponentTemplate")]
    public class UDatasmithSceneComponentTemplate : UDatasmithObjectTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}