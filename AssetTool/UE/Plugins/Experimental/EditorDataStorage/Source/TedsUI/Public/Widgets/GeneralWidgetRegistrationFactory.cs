namespace AssetTool
{
    [JsonAsset("GeneralWidgetRegistrationFactory")]
    public class UGeneralWidgetRegistrationFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}