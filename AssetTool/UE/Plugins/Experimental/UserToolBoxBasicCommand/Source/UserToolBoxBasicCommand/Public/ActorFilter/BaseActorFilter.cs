namespace AssetTool
{
    [JsonAsset("BaseActorFilter")]
    public class UBaseActorFilter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GetAllDescendants")]
    public class UGetAllDescendants : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GetParents")]
    public class UGetParents : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HasAttachedActor")]
    public class UHasAttachedActor : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HasComponentOfClass")]
    public class UHasComponentOfClass : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HasMetadataByKey")]
    public class UHasMetadataByKey : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HasMetadataByKeyAndValue")]
    public class UHasMetadataByKeyAndValue : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("IsClassOf")]
    public class UIsClassOf : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GetNDescendants")]
    public class UGetNDescendants : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HasMetadataByKeyAndValueDropDown")]
    public class UHasMetadataByKeyAndValueDropDown : UBaseActorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}