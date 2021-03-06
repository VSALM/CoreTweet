﻿// The MIT License (MIT)
//
// CoreTweet - A .NET Twitter Library supporting Twitter API 1.1
// Copyright (c) 2014 lambdalice
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CoreTweet.Rest
{
    partial class Friendships
    {
        //GET Methods

        /// <summary>
        /// <para>Returns a collection of user_ids that the currently authenticated user does not want to receive retweets from.</para>
        /// <para>Use POST friendships/update to set the "no retweets" status for a given user account on behalf of the current user.</para>
        /// <para>Avaliable parameters: Nothing.</para>
        /// </summary>
        /// <returns>
        /// IDs.
        /// </returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<IEnumerable<long>> NoRetweetsIdsAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiArrayAsync<long>(MethodType.Get, "friendships/no_retweets/ids", parameters);
        }
        public Task<IEnumerable<long>> NoRetweetsIdsAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiArrayAsync<long>(MethodType.Get, "friendships/no_retweets/ids", parameters, cancellationToken);
        }
        public Task<IEnumerable<long>> NoRetweetsIdsAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiArrayAsync<long, T>(MethodType.Get, "friendships/no_retweets/ids", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Returns a collection of numeric IDs for every user who has a pending request to follow the authenticating user.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="long cursor (semi-optional)"/> : Causes the list of connections to be broken into pages of no more than 5000 IDs at a time. The number of IDs returned is not guaranteed to be 5000 as suspended users are filtered out after connections are queried. If no cursor is provided, a value of -1 will be assumed, which is the first "page." The response from the API will include a previous_cursor and next_cursor to allow paging back and forth. See Using cursors to navigate collections for more information.</para>
        /// </summary>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        /// <returns>IDs.</returns>
        /// <see cref="https://dev.twitter.com/docs/misc/cursoring"/>
        public Task<Cursored<long>> IncomingAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<Cursored<long>>(MethodType.Get, "friendships/incoming", parameters);
        }
        public Task<Cursored<long>> IncomingAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<Cursored<long>>(MethodType.Get, "friendships/incoming", parameters, cancellationToken);
        }
        public Task<Cursored<long>> IncomingAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<Cursored<long>, T>(MethodType.Get, "friendships/incoming", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Returns a collection of numeric IDs for every protected user for whom the authenticating user has a pending follow request.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="long cursor (semi-optional)"/> : Causes the list of connections to be broken into pages of no more than 5000 IDs at a time. The number of IDs returned is not guaranteed to be 5000 as suspended users are filtered out after connections are queried. If no cursor is provided, a value of -1 will be assumed, which is the first "page."The response from the API will include a previous_cursor and next_cursor to allow paging back and forth. See Using cursors to navigate collections for more information.</para>
        /// </summary>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        /// <returns>IDs.</returns>
        /// <see cref="https://dev.twitter.com/docs/misc/cursoring"/>
        public Task<Cursored<long>> OutgoingAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<Cursored<long>>(MethodType.Get, "friendships/outgoing", parameters);
        }
        public Task<Cursored<long>> OutgoingAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<Cursored<long>>(MethodType.Get, "friendships/outgoing", parameters, cancellationToken);
        }
        public Task<Cursored<long>> OutgoingAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<Cursored<long>, T>(MethodType.Get, "friendships/outgoing", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Returns the relationships of the authenticating user to the comma-separated list of up to 100 screen_names or user_ids provided. Values for connections can be: following, following_requested, followed_by, none.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="string, IEnumerable<string> screen_name (optional)"/> : A list of screen names or comma separated string of ones, up to 100 are allowed in a single request.</para>
        /// <para><paramref name="string, IEnumerable<long> user_id (ooptional)"/> : A list of user IDs or comma separated string of ones, up to 100 are allowed in a single request.</para>
        /// </summary>
        /// <returns>The Friendships.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<IEnumerable<Friendship>> LookupAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiArrayAsync<Friendship>(MethodType.Get, "friendships/lookup", parameters);
        }
        public Task<IEnumerable<Friendship>> LookupAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiArrayAsync<Friendship>(MethodType.Get, "friendships/lookup", parameters, cancellationToken);
        }
        public Task<IEnumerable<Friendship>> LookupAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiArrayAsync<Friendship, T>(MethodType.Get, "friendships/lookup", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Returns detailed information about the relationship between two arbitrary users.</para>
        /// <para>Note: At least one source and one target, whether specified by IDs or screen_names, should be provided to this method.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="long source_id (optional)"/> : The user_id of the subject user.</para>
        /// <para><paramref name="string source_screen_name (optional)"/> : The screen_name of the subject user.</para>
        /// <para><paramref name="long target_id (optional)"/> : The user_id of the target user.</para>
        /// <para><paramref name="string target_screen_name (optional)"/> : The screen_name of the target user.</para>
        /// </summary>
        /// <returns>The relationship.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<RelationShip> ShowAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<RelationShip>(MethodType.Get, "friendships/show", parameters, "relationship");
        }
        public Task<RelationShip> ShowAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<RelationShip>(MethodType.Get, "friendships/show", parameters, cancellationToken, "relationship");
        }
        public Task<RelationShip> ShowAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<RelationShip, T>(MethodType.Get, "friendships/show", parameters, cancellationToken, "relationship");
        }

        //POST Methods

        /// <summary>
        /// <para>Allows the authenticating users to follow the user specified in the ID parameter.</para>
        /// <para>Returns the befriended user in the requested format when successful. Returns a string describing the failure condition when unsuccessful. If you are already friends with the user a HTTP 403 may be returned, though for performance reasons you may get a 200 OK message even if the friendship already exists.</para>
        /// <para>Actions taken in this method are asynchronous and changes will be eventually consistent.</para>
        /// <para>Note: Providing either screen_name or user_id is required.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="string screen_name (optional)"/> : The screen name of the user for whom to befriend.</para>
        /// <para><paramref name="long user_id (optional)"/> : The ID of the user for whom to befriend.</para>
        /// <para><paramref name="bool follow (optional)"/> : Enable notifications for the target user.</para>
        /// </summary>
        /// <returns>The user.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<User> CreateAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<User>(MethodType.Post, "friendships/create", parameters);
        }
        public Task<User> CreateAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<User>(MethodType.Post, "friendships/create", parameters, cancellationToken);
        }
        public Task<User> CreateAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<User, T>(MethodType.Post, "friendships/create", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Allows the authenticating user to unfollow the user specified in the ID parameter.</para>
        /// <para>Returns the unfollowed user in the requested format when successful. Returns a string describing the failure condition when unsuccessful.</para>
        /// <para>Actions taken in this method are asynchronous and changes will be eventually consistent.</para>
        /// <para>Note: Providing either screen_name or user_id is required.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="string screen_name (optional)"/> : The screen name of the user for whom to unfollow.</para>
        /// <para><paramref name="long user_id (optional)"/> : The ID of the user for whom to unfollow.</para>
        /// </summary>
        /// <returns>The user.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<User> DestroyAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<User>(MethodType.Post, "friendships/destroy", parameters);
        }
        public Task<User> DestroyAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<User>(MethodType.Post, "friendships/destroy", parameters, cancellationToken);
        }
        public Task<User> DestroyAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<User, T>(MethodType.Post, "friendships/destroy", parameters, cancellationToken);
        }

        /// <summary>
        /// <para>Allows one to enable or disable retweets and device notifications from the specified user.</para>
        /// <para>Note: Providing either screen_name or user_id is required.</para>
        /// <para>Avaliable parameters: </para>
        /// <para><paramref name="string screen_name (optional)"/> : The screen name of the user for whom to befriend.</para>
        /// <para><paramref name="long user_id (optional)"/> : The ID of the user for whom to befriend.</para>/// <para><paramref name=""/> :</para>
        /// <para><paramref name="bool device (optional)"/> : Enable/disable device notifications from the target user.</para>
        /// <para><paramref name="bool retweets (optional)"/> : Enable/disable retweets from the target user.</para>
        /// </summary>
        /// <returns>The relationship.</returns>
        /// <param name='parameters'>
        /// Parameters.
        /// </param>
        public Task<RelationShip> UpdateAsync(params Expression<Func<string, object>>[] parameters)
        {
            return this.Tokens.AccessApiAsync<RelationShip>(MethodType.Post, "friendships/update", parameters, "relationship");
        }
        public Task<RelationShip> UpdateAsync(IDictionary<string, object> parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<RelationShip>(MethodType.Post, "friendships/update", parameters, cancellationToken, "relationship");
        }
        public Task<RelationShip> UpdateAsync<T>(T parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.Tokens.AccessApiAsync<RelationShip, T>(MethodType.Post, "friendships/update", parameters, cancellationToken, "relationship");
        }
    }
}
