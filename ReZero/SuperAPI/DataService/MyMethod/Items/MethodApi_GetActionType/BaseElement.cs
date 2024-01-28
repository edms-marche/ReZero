﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReZero.SuperAPI
{
    public class BaseElement
    {
        protected void AddActionTypeFormElementModels(List<ActionTypeFormElementModel> result) 
        {
            AddInterfaceName(result);
            AddTable(result);
            AddInterfacUrl(result);
            AddGroup(result);
        }
        private void AddInterfacUrl(List<ActionTypeFormElementModel> result)
        {
            result.Add(new ActionTypeFormElementModel()
            {
                Name = nameof(ZeroInterfaceList.Url),
                Text = TextHandler.GetCommonText("Url", "Url"),
                ElementType = ElementType.Text,
                Placeholder = TextHandler.GetCommonText("默认自动", "Default is auto")
            }); ;
        }

        private void AddInterfaceName(List<ActionTypeFormElementModel> result)
        {
            result.Add(new ActionTypeFormElementModel()
            {
                Name = nameof(ZeroInterfaceList.Name),
                Text= TextHandler.GetCommonText("接口名称","Interface name"),
                ElementType = ElementType.Text,
                IsRequired = true
            });
        }

        private void AddTable(List<ActionTypeFormElementModel> result)
        {
            result.Add(new ActionTypeFormElementModel()
            {
                Name = nameof(DataModel.TableId),
                Text = TextHandler.GetCommonText("实体/表", "Entity/Table name"),
                ElementType = ElementType.Table,
                IsRequired = true
            });
        }

        private void AddGroup(List<ActionTypeFormElementModel> result)
        {
            result.Add(new ActionTypeFormElementModel()
            {
                Name = nameof(ZeroInterfaceList.GroupName),
                Text = TextHandler.GetCommonText("分组名", "Group name"),
                ElementType = ElementType.Text ,
                Placeholder= TextHandler.GetCommonText("默认为实体名","Default is entity name")
            });
        }
    }
}
