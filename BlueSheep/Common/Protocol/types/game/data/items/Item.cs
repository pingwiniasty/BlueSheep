


















// Generated on 12/11/2014 19:02:08
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class Item
{

public new const short ID = 7;
public virtual short TypeId
{
    get { return ID; }
}



public Item()
{
}



public virtual void Serialize(BigEndianWriter writer)
{



}

public virtual void Deserialize(BigEndianReader reader)
{



}


}


}