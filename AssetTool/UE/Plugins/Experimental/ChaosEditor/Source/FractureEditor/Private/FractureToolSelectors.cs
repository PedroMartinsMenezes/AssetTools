namespace AssetTool
{
    [JsonAsset("FractureToolSelectAll")]
    public class UFractureToolSelectAll : UFractureActionTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectNone")]
    public class UFractureToolSelectNone : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectNeighbors")]
    public class UFractureToolSelectNeighbors : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectParent")]
    public class UFractureToolSelectParent : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectChildren")]
    public class UFractureToolSelectChildren : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectSiblings")]
    public class UFractureToolSelectSiblings : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectAllInLevel")]
    public class UFractureToolSelectAllInLevel : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectInvert")]
    public class UFractureToolSelectInvert : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectLeaf")]
    public class UFractureToolSelectLeaf : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelectCluster")]
    public class UFractureToolSelectCluster : UFractureToolSelectAll
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}