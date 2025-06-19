namespace AssetTool
{
    [JsonAsset("SceneImportFactory")]
    public class USceneImportFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}