using Desktop.Model.Authorization.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Model.Authorization
{
    class Role
    {
        public string Name { get; set; }
        List<ActionLevel> allowedActions;


        public Role()
        {
            allowedActions = new List<ActionLevel>();
        }

        public Role(string name, params ActionLevel [] actions )
        {
            Name = name;
            allowedActions = new List<ActionLevel>();
            foreach (ActionLevel i in actions)
            {
                Allow(i);
            }
        }


        /// <summary>
        /// Adds specified action to set of actions that user with this role is allowed to take
        /// </summary>
        /// <param name="action"></param>
        public void Allow(ActionLevel action)
        {
            foreach(ActionLevel i in allowedActions)
            {
                if (i == action)
                    return;
            }
            allowedActions.Add(action);
        }

        /// <summary>
        /// Removes specified action from set of actions that are allowed by this role
        /// </summary>
        /// <param name="action"></param>
        void Disallow(ActionLevel action)
        {
            foreach (ActionLevel i in allowedActions)
            {
                if (i == action)
                {
                    allowedActions.Remove(action);
                    return;
                }
            }
        }

        /// <summary>
        /// Checks whether yhis role allows user to take specified action
        /// </summary>
        /// <param name="action">Action to test</param>
        /// <returns>True if it is possible to take action, false otherwise</returns>
        public bool Allows(ActionLevel action)
        {
            foreach(ActionLevel a in allowedActions)
            {
                if (a == action)
                    return true;
            }
            return false;
        }
    }
}
